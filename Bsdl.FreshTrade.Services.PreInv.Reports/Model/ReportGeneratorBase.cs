using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Reports.Model
{
    public abstract class ReportGeneratorBase
    {
        public abstract bool IsReportTypeSupported(string reportType);
        public abstract List<DataTable> GenerateReport(IUnitOfWork unitOfWorkCurrent, int extractSessionID, string reportType, Dictionary<string, string> reportParams);

        #region Helpers
        private ICollection<PropertyInfo> InitializeDataTableFromDTO(DataTable table, string name, Type type)
        {
            table.TableName = name;
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                table.Columns.Add(new DataColumn(prop.Name, prop.PropertyType));
            }
            return props;
        }

        private void InsertDataTableRowFromDTO(DataTable table, object[] buffer, IEnumerable<PropertyInfo> props, object dto)
        {
            int i = 0;
            foreach (var prop in props)
            {
                buffer[i] = prop.GetValue(dto, null);
                i++;
            }
            table.LoadDataRow(buffer, true);
        }

        protected DataTable BuildDataTable(string name, object dto)
        {
            var result = new DataTable();
            var props = InitializeDataTableFromDTO(result, name, dto.GetType());
            var values = new object[props.Count()];
            result.BeginLoadData();
            InsertDataTableRowFromDTO(result, values, props, dto);
            result.EndLoadData();
            return result;
        }

        protected DataTable BuildDataTable(string name, Type type, IEnumerable dtos)
        {
            var result = new DataTable();
            var props = InitializeDataTableFromDTO(result, name, type);
            var values = new object[props.Count()];
            result.BeginLoadData();
            foreach (var dto in dtos)
            {
                InsertDataTableRowFromDTO(result, values, props, dto);
            }
            result.EndLoadData();
            return result;
        }
        #endregion
    }
}
