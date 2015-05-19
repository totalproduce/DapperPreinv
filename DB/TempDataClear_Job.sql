--Clear Pre-Invoicing temp data
BEGIN
    DBMS_SCHEDULER.CREATE_JOB (
            job_name => '"PFITTER"."ClearPreInvTempDataJob"',
            job_type => 'STORED_PROCEDURE',
            job_action => 'PFITTER.CLEARPREINVTEMPDATA',
            number_of_arguments => 0,
            start_date => NULL,
            repeat_interval => 'FREQ=DAILY;BYDAY=MON,TUE,WED,THU,FRI,SAT,SUN;BYHOUR=1;BYMINUTE=0;BYSECOND=0',
            end_date => NULL,
            enabled => FALSE,
            auto_drop => FALSE,
            comments => 'Clear Pre-Invoicing temp data');

         
     
 
	DBMS_SCHEDULER.set_attribute( 
		name => '"PFITTER"."ClearPreInvTempDataJob"', attribute => 
			'logging_level', value => DBMS_SCHEDULER.LOGGING_FAILED_RUNS);      
  
    
    DBMS_SCHEDULER.enable(
             name => '"PFITTER"."ClearPreInvTempDataJob"');
END;
