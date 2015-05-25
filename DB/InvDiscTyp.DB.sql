DROP TABLE PREINVTEMP_InvDiscTyp;
CREATE TABLE PREINVTEMP_InvDiscTyp  (
  ExtractSessionID NUMBER(10,0)  NOT NULL ENABLE,
  DlvInvoiceNo VARCHAR(20),
  RecNo NUMBER(10,0),
  DiscSeqNo NUMBER(10,0),
  DiscTyp NUMBER(10,0),
  DiscRate FLOAT(126),
  DiscDetrStr VARCHAR(30),
  DiscBaseAmt FLOAT(126),
  DiscLoclAmt FLOAT(126),
  DiscEuroAmt FLOAT(126),
  DiscGLRecNo NUMBER(10,0),
  IchRecNo NUMBER(10,0)
);