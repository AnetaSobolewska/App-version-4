﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace TourismV3
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace TourismV3.TourismV3_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[12];
            _typeNameTable[0] = "TourismV3.ViewModels.RestViewModel";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "TourismV3.Common.RelayCommand";
            _typeNameTable[3] = "TourismV3.Models.RestModel";
            _typeNameTable[4] = "System.Collections.ObjectModel.ObservableCollection`1<TourismV3.Models.RestModel>";
            _typeNameTable[5] = "System.Collections.ObjectModel.Collection`1<TourismV3.Models.RestModel>";
            _typeNameTable[6] = "Int32";
            _typeNameTable[7] = "String";
            _typeNameTable[8] = "TourismV3.Views.RestAdmin";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[11] = "TourismV3.Views.Startpage";

            _typeTable = new global::System.Type[12];
            _typeTable[0] = typeof(global::TourismV3.ViewModels.RestViewModel);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::TourismV3.Common.RelayCommand);
            _typeTable[3] = typeof(global::TourismV3.Models.RestModel);
            _typeTable[4] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::TourismV3.Models.RestModel>);
            _typeTable[5] = typeof(global::System.Collections.ObjectModel.Collection<global::TourismV3.Models.RestModel>);
            _typeTable[6] = typeof(global::System.Int32);
            _typeTable[7] = typeof(global::System.String);
            _typeTable[8] = typeof(global::TourismV3.Views.RestAdmin);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[11] = typeof(global::TourismV3.Views.Startpage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_RestViewModel() { return new global::TourismV3.ViewModels.RestViewModel(); }
        private object Activate_3_RestModel() { return new global::TourismV3.Models.RestModel(); }
        private object Activate_4_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::TourismV3.Models.RestModel>(); }
        private object Activate_5_Collection() { return new global::System.Collections.ObjectModel.Collection<global::TourismV3.Models.RestModel>(); }
        private object Activate_8_RestAdmin() { return new global::TourismV3.Views.RestAdmin(); }
        private object Activate_11_Startpage() { return new global::TourismV3.Views.Startpage(); }
        private void VectorAdd_4_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::TourismV3.Models.RestModel>)instance;
            var newItem = (global::TourismV3.Models.RestModel)item;
            collection.Add(newItem);
        }
        private void VectorAdd_5_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::TourismV3.Models.RestModel>)instance;
            var newItem = (global::TourismV3.Models.RestModel)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  TourismV3.ViewModels.RestViewModel
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_RestViewModel;
                userType.AddMemberName("AddRestCommand");
                userType.AddMemberName("DelRestCommand");
                userType.AddMemberName("SelectedRestaurant");
                userType.AddMemberName("NewRestaurant");
                userType.AddMemberName("Restaurants");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  TourismV3.Common.RelayCommand
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  TourismV3.Models.RestModel
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_RestModel;
                userType.AddMemberName("ID");
                userType.AddMemberName("RestName");
                userType.AddMemberName("RestAddress");
                userType.AddMemberName("RestPhone");
                userType.AddMemberName("RestFood");
                userType.AddMemberName("RestDescription");
                userType.AddMemberName("RestPicture1");
                userType.AddMemberName("RestPicture2");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  System.Collections.ObjectModel.ObservableCollection`1<TourismV3.Models.RestModel>
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<TourismV3.Models.RestModel>"));
                userType.CollectionAdd = VectorAdd_4_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 5:   //  System.Collections.ObjectModel.Collection`1<TourismV3.Models.RestModel>
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_5_Collection;
                userType.CollectionAdd = VectorAdd_5_Collection;
                xamlType = userType;
                break;

            case 6:   //  Int32
                xamlType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  String
                xamlType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  TourismV3.Views.RestAdmin
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_RestAdmin;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  TourismV3.Views.Startpage
                userType = new global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_Startpage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_RestViewModel_AddRestCommand(object instance)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            return that.AddRestCommand;
        }
        private void set_0_RestViewModel_AddRestCommand(object instance, object Value)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            that.AddRestCommand = (global::TourismV3.Common.RelayCommand)Value;
        }
        private object get_1_RestViewModel_DelRestCommand(object instance)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            return that.DelRestCommand;
        }
        private void set_1_RestViewModel_DelRestCommand(object instance, object Value)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            that.DelRestCommand = (global::TourismV3.Common.RelayCommand)Value;
        }
        private object get_2_RestViewModel_SelectedRestaurant(object instance)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            return that.SelectedRestaurant;
        }
        private void set_2_RestViewModel_SelectedRestaurant(object instance, object Value)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            that.SelectedRestaurant = (global::TourismV3.Models.RestModel)Value;
        }
        private object get_3_RestViewModel_NewRestaurant(object instance)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            return that.NewRestaurant;
        }
        private void set_3_RestViewModel_NewRestaurant(object instance, object Value)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            that.NewRestaurant = (global::TourismV3.Models.RestModel)Value;
        }
        private object get_4_RestViewModel_Restaurants(object instance)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            return that.Restaurants;
        }
        private void set_4_RestViewModel_Restaurants(object instance, object Value)
        {
            var that = (global::TourismV3.ViewModels.RestViewModel)instance;
            that.Restaurants = (global::System.Collections.ObjectModel.ObservableCollection<global::TourismV3.Models.RestModel>)Value;
        }
        private object get_5_RestModel_ID(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.ID;
        }
        private void set_5_RestModel_ID(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.ID = (global::System.Int32)Value;
        }
        private object get_6_RestModel_RestName(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestName;
        }
        private void set_6_RestModel_RestName(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestName = (global::System.String)Value;
        }
        private object get_7_RestModel_RestAddress(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestAddress;
        }
        private void set_7_RestModel_RestAddress(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestAddress = (global::System.String)Value;
        }
        private object get_8_RestModel_RestPhone(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestPhone;
        }
        private void set_8_RestModel_RestPhone(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestPhone = (global::System.Int32)Value;
        }
        private object get_9_RestModel_RestFood(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestFood;
        }
        private void set_9_RestModel_RestFood(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestFood = (global::System.String)Value;
        }
        private object get_10_RestModel_RestDescription(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestDescription;
        }
        private void set_10_RestModel_RestDescription(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestDescription = (global::System.String)Value;
        }
        private object get_11_RestModel_RestPicture1(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestPicture1;
        }
        private void set_11_RestModel_RestPicture1(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestPicture1 = (global::System.String)Value;
        }
        private object get_12_RestModel_RestPicture2(object instance)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            return that.RestPicture2;
        }
        private void set_12_RestModel_RestPicture2(object instance, object Value)
        {
            var that = (global::TourismV3.Models.RestModel)instance;
            that.RestPicture2 = (global::System.String)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::TourismV3.TourismV3_XamlTypeInfo.XamlMember xamlMember = null;
            global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "TourismV3.ViewModels.RestViewModel.AddRestCommand":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.ViewModels.RestViewModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "AddRestCommand", "TourismV3.Common.RelayCommand");
                xamlMember.Getter = get_0_RestViewModel_AddRestCommand;
                xamlMember.Setter = set_0_RestViewModel_AddRestCommand;
                break;
            case "TourismV3.ViewModels.RestViewModel.DelRestCommand":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.ViewModels.RestViewModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "DelRestCommand", "TourismV3.Common.RelayCommand");
                xamlMember.Getter = get_1_RestViewModel_DelRestCommand;
                xamlMember.Setter = set_1_RestViewModel_DelRestCommand;
                break;
            case "TourismV3.ViewModels.RestViewModel.SelectedRestaurant":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.ViewModels.RestViewModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "SelectedRestaurant", "TourismV3.Models.RestModel");
                xamlMember.Getter = get_2_RestViewModel_SelectedRestaurant;
                xamlMember.Setter = set_2_RestViewModel_SelectedRestaurant;
                break;
            case "TourismV3.ViewModels.RestViewModel.NewRestaurant":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.ViewModels.RestViewModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "NewRestaurant", "TourismV3.Models.RestModel");
                xamlMember.Getter = get_3_RestViewModel_NewRestaurant;
                xamlMember.Setter = set_3_RestViewModel_NewRestaurant;
                break;
            case "TourismV3.ViewModels.RestViewModel.Restaurants":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.ViewModels.RestViewModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "Restaurants", "System.Collections.ObjectModel.ObservableCollection`1<TourismV3.Models.RestModel>");
                xamlMember.Getter = get_4_RestViewModel_Restaurants;
                xamlMember.Setter = set_4_RestViewModel_Restaurants;
                break;
            case "TourismV3.Models.RestModel.ID":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "ID", "Int32");
                xamlMember.Getter = get_5_RestModel_ID;
                xamlMember.Setter = set_5_RestModel_ID;
                break;
            case "TourismV3.Models.RestModel.RestName":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestName", "String");
                xamlMember.Getter = get_6_RestModel_RestName;
                xamlMember.Setter = set_6_RestModel_RestName;
                break;
            case "TourismV3.Models.RestModel.RestAddress":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestAddress", "String");
                xamlMember.Getter = get_7_RestModel_RestAddress;
                xamlMember.Setter = set_7_RestModel_RestAddress;
                break;
            case "TourismV3.Models.RestModel.RestPhone":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestPhone", "Int32");
                xamlMember.Getter = get_8_RestModel_RestPhone;
                xamlMember.Setter = set_8_RestModel_RestPhone;
                break;
            case "TourismV3.Models.RestModel.RestFood":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestFood", "String");
                xamlMember.Getter = get_9_RestModel_RestFood;
                xamlMember.Setter = set_9_RestModel_RestFood;
                break;
            case "TourismV3.Models.RestModel.RestDescription":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestDescription", "String");
                xamlMember.Getter = get_10_RestModel_RestDescription;
                xamlMember.Setter = set_10_RestModel_RestDescription;
                break;
            case "TourismV3.Models.RestModel.RestPicture1":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestPicture1", "String");
                xamlMember.Getter = get_11_RestModel_RestPicture1;
                xamlMember.Setter = set_11_RestModel_RestPicture1;
                break;
            case "TourismV3.Models.RestModel.RestPicture2":
                userType = (global::TourismV3.TourismV3_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TourismV3.Models.RestModel");
                xamlMember = new global::TourismV3.TourismV3_XamlTypeInfo.XamlMember(this, "RestPicture2", "String");
                xamlMember.Getter = get_12_RestModel_RestPicture2;
                xamlMember.Setter = set_12_RestModel_RestPicture2;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::TourismV3.TourismV3_XamlTypeInfo.XamlSystemBaseType
    {
        global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::TourismV3.TourismV3_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


