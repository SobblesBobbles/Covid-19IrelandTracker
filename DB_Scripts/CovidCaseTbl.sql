begin tran

create table Covid_Ireland_Cases 

(
	 Covid_Case_Id int IDENTITY(1,1) Primary KEY,
	 Date_Diagnosed DATE not null, 
	 AgeGroup VARCHAR(30) not null,
	 Gender VARCHAR(30) not null
)

commit