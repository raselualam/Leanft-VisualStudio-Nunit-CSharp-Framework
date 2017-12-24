<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>MyNamespace</name>
  <className>PageThreeObject</className>
  <objects>
    <object technology="Web" type="Page">
      <name>Aplication Name</name>
      <codeName>PageTwo</codeName>
      <identification />
      <children>
        <object technology="Web" type="EditField">
          <name>Obj1</name>
          <codeName>Obj1EditField</codeName>
          <identification>
            <properties>
              <property name="Type" type="string">text</property>
              <property name="TagName" type="string">input</property>
              <property name="Name" type="string">Obj1</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="EditField">
          <name>Obj2</name>
          <codeName>EditField</codeName>
          <identification>
            <properties>
              <property name="Type" type="string">text</property>
              <property name="TagName" type="string">input</property>
              <property name="Name" type="string">Obj2</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="EditField">
          <name>Obj3</name>
          <codeName>EditField</codeName>
          <identification>
            <properties>
              <property name="Type" type="string">text</property>
              <property name="TagName" type="string">input</property>
              <property name="Name" type="string">Obj3</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="ListBox">
          <name>Obj4</name>
          <codeName>Obj4ListBox</codeName>
          <identification>
            <properties>
              <property name="Role" type="string">listbox</property>
              <property name="AccessibilityName" type="string">Obj4</property>
              <property name="TagName" type="string">select</property>
              <property name="Name" type="string">select</property>
            </properties>
            <index>0</index>
          </identification>
        </object>
        <object technology="Web" type="Button">
          <name>Obj5</name>
          <codeName>Obj5Button</codeName>
          <identification>
            <properties>
              <property name="ButtonType" type="string">submit</property>
              <property name="TagName" type="string">INPUT</property>
              <property name="Name" type="string">Next</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>