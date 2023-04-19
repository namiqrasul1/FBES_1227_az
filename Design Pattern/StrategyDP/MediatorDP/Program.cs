using MediatorDP;

Transfer transfer = new Transfer();
XCompany xCompany=new XCompany(transfer);
YCompany yCompany = new YCompany(transfer);
ZCompany zCompany = new ZCompany(transfer);
transfer.XCompany= xCompany;
transfer.YCompany= yCompany;
transfer.ZCompany= zCompany;

xCompany.StartTransport();
