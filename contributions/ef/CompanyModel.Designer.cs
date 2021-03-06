﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("CompanyModel", "R_11", "Company", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(csharpEntityFramework.Company), "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(csharpEntityFramework.Department), true)]
[assembly: EdmRelationshipAttribute("CompanyModel", "FK_Department_Departmnent", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(csharpEntityFramework.Department), "Department1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(csharpEntityFramework.Department), true)]
[assembly: EdmRelationshipAttribute("CompanyModel", "R_15", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(csharpEntityFramework.Department), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(csharpEntityFramework.Employee), true)]
[assembly: EdmRelationshipAttribute("CompanyModel", "R_14", "Person", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(csharpEntityFramework.Person), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(csharpEntityFramework.Employee), true)]

#endregion

namespace csharpEntityFramework
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CompanyDataContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CompanyDataContext object using the connection string found in the 'CompanyDataContext' section of the application configuration file.
        /// </summary>
        public CompanyDataContext() : base("name=CompanyDataContext", "CompanyDataContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CompanyDataContext object.
        /// </summary>
        public CompanyDataContext(string connectionString) : base(connectionString, "CompanyDataContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CompanyDataContext object.
        /// </summary>
        public CompanyDataContext(EntityConnection connection) : base(connection, "CompanyDataContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Company> Companies
        {
            get
            {
                if ((_Companies == null))
                {
                    _Companies = base.CreateObjectSet<Company>("Companies");
                }
                return _Companies;
            }
        }
        private ObjectSet<Company> _Companies;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Person> People
        {
            get
            {
                if ((_People == null))
                {
                    _People = base.CreateObjectSet<Person>("People");
                }
                return _People;
            }
        }
        private ObjectSet<Person> _People;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Companies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCompanies(Company company)
        {
            base.AddObject("Companies", company);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CompanyModel", Name="Company")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Company : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Company object.
        /// </summary>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="company_id">Initial value of the company_id property.</param>
        public static Company CreateCompany(global::System.String name, global::System.Guid company_id)
        {
            Company company = new Company();
            company.Name = name;
            company.company_id = company_id;
            return company;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid company_id
        {
            get
            {
                return _company_id;
            }
            set
            {
                if (_company_id != value)
                {
                    Oncompany_idChanging(value);
                    ReportPropertyChanging("company_id");
                    _company_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("company_id");
                    Oncompany_idChanged();
                }
            }
        }
        private global::System.Guid _company_id;
        partial void Oncompany_idChanging(global::System.Guid value);
        partial void Oncompany_idChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "R_11", "Department")]
        public EntityCollection<Department> Departments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Department>("CompanyModel.R_11", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Department>("CompanyModel.R_11", "Department", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CompanyModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="department_id">Initial value of the department_id property.</param>
        public static Department CreateDepartment(global::System.Guid department_id)
        {
            Department department = new Department();
            department.department_id = department_id;
            return department;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid department_id
        {
            get
            {
                return _department_id;
            }
            set
            {
                if (_department_id != value)
                {
                    Ondepartment_idChanging(value);
                    ReportPropertyChanging("department_id");
                    _department_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("department_id");
                    Ondepartment_idChanged();
                }
            }
        }
        private global::System.Guid _department_id;
        partial void Ondepartment_idChanging(global::System.Guid value);
        partial void Ondepartment_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Guid> company_id
        {
            get
            {
                return _company_id;
            }
            set
            {
                Oncompany_idChanging(value);
                ReportPropertyChanging("company_id");
                _company_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("company_id");
                Oncompany_idChanged();
            }
        }
        private Nullable<global::System.Guid> _company_id;
        partial void Oncompany_idChanging(Nullable<global::System.Guid> value);
        partial void Oncompany_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Guid> parent_id
        {
            get
            {
                return _parent_id;
            }
            set
            {
                Onparent_idChanging(value);
                ReportPropertyChanging("parent_id");
                _parent_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("parent_id");
                Onparent_idChanged();
            }
        }
        private Nullable<global::System.Guid> _parent_id;
        partial void Onparent_idChanging(Nullable<global::System.Guid> value);
        partial void Onparent_idChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "R_11", "Company")]
        public Company Company
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("CompanyModel.R_11", "Company").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("CompanyModel.R_11", "Company").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Company> CompanyReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("CompanyModel.R_11", "Company");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Company>("CompanyModel.R_11", "Company", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "FK_Department_Departmnent", "Department1")]
        public EntityCollection<Department> SubUnits
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Department>("CompanyModel.FK_Department_Departmnent", "Department1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Department>("CompanyModel.FK_Department_Departmnent", "Department1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "FK_Department_Departmnent", "Department")]
        public Department Parent
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("CompanyModel.FK_Department_Departmnent", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("CompanyModel.FK_Department_Departmnent", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> ParentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("CompanyModel.FK_Department_Departmnent", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("CompanyModel.FK_Department_Departmnent", "Department", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "R_15", "Employee")]
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("CompanyModel.R_15", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("CompanyModel.R_15", "Employee", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CompanyModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employee_id">Initial value of the employee_id property.</param>
        /// <param name="person_id">Initial value of the person_id property.</param>
        /// <param name="department_id">Initial value of the department_id property.</param>
        public static Employee CreateEmployee(global::System.Guid employee_id, global::System.Guid person_id, global::System.Guid department_id)
        {
            Employee employee = new Employee();
            employee.employee_id = employee_id;
            employee.person_id = person_id;
            employee.department_id = department_id;
            return employee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private Nullable<global::System.Decimal> _Salary;
        partial void OnSalaryChanging(Nullable<global::System.Decimal> value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid employee_id
        {
            get
            {
                return _employee_id;
            }
            set
            {
                if (_employee_id != value)
                {
                    Onemployee_idChanging(value);
                    ReportPropertyChanging("employee_id");
                    _employee_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("employee_id");
                    Onemployee_idChanged();
                }
            }
        }
        private global::System.Guid _employee_id;
        partial void Onemployee_idChanging(global::System.Guid value);
        partial void Onemployee_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid person_id
        {
            get
            {
                return _person_id;
            }
            set
            {
                if (_person_id != value)
                {
                    Onperson_idChanging(value);
                    ReportPropertyChanging("person_id");
                    _person_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("person_id");
                    Onperson_idChanged();
                }
            }
        }
        private global::System.Guid _person_id;
        partial void Onperson_idChanging(global::System.Guid value);
        partial void Onperson_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid department_id
        {
            get
            {
                return _department_id;
            }
            set
            {
                if (_department_id != value)
                {
                    Ondepartment_idChanging(value);
                    ReportPropertyChanging("department_id");
                    _department_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("department_id");
                    Ondepartment_idChanged();
                }
            }
        }
        private global::System.Guid _department_id;
        partial void Ondepartment_idChanging(global::System.Guid value);
        partial void Ondepartment_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> IsManager
        {
            get
            {
                return _IsManager;
            }
            set
            {
                OnIsManagerChanging(value);
                ReportPropertyChanging("IsManager");
                _IsManager = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsManager");
                OnIsManagerChanged();
            }
        }
        private Nullable<global::System.Boolean> _IsManager;
        partial void OnIsManagerChanging(Nullable<global::System.Boolean> value);
        partial void OnIsManagerChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "R_15", "Department")]
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("CompanyModel.R_15", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("CompanyModel.R_15", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("CompanyModel.R_15", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("CompanyModel.R_15", "Department", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "R_14", "Person")]
        public Person Person
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("CompanyModel.R_14", "Person").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("CompanyModel.R_14", "Person").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Person> PersonReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("CompanyModel.R_14", "Person");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Person>("CompanyModel.R_14", "Person", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CompanyModel", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="person_id">Initial value of the person_id property.</param>
        public static Person CreatePerson(global::System.Guid person_id)
        {
            Person person = new Person();
            person.person_id = person_id;
            return person;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid person_id
        {
            get
            {
                return _person_id;
            }
            set
            {
                if (_person_id != value)
                {
                    Onperson_idChanging(value);
                    ReportPropertyChanging("person_id");
                    _person_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("person_id");
                    Onperson_idChanged();
                }
            }
        }
        private global::System.Guid _person_id;
        partial void Onperson_idChanging(global::System.Guid value);
        partial void Onperson_idChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CompanyModel", "R_14", "Employee")]
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("CompanyModel.R_14", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("CompanyModel.R_14", "Employee", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
