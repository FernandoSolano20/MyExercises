   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   �        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   F   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   ,myclr-namespace:WpfApplication1     6�   -   5          � Title$  
MainWindow��5   	   $	��321��6   $	��566��6)    � 	Resources 5         customersViewSource��%   &	        �� 5   
   6   5      .��5      � $	��285��6   $	��529��6    � DataContext# [  6$   .+�5	   
   &   System.Windows.Controls.DataGrid  -   5        $��customersDataGrid��5	   �      AutoGenerateColumns .     EnableRowVirtualization . $	��200��6N   $
��Left=�6[   $��	19,44,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��Top=�6�   $	��400��6  ��6v   ��    Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        customerIDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��5   c      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6x   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� 
 �� Path$
 
CustomerID�6x     5      -   5        titleColumn��$ Title��5   Y   $ SizeToHeader 6h   	 6:   �� $
 Title�6h     5      -   5        firstNameColumn��$ 
First Name��5   a   $ SizeToHeader 6u   	 6>   �� $
 	FirstName�6u     5      -   5        middleNameColumn��$ Middle Name��5   c   $ SizeToHeader 6x   	 6?   �� $
 
MiddleName�6x     5      -   5        lastNameColumn��$ 	Last Name��5   _   $ SizeToHeader 6r   	 6=   �� $
 LastName�6r     5      -   5        suffixColumn��$ Suffix��5   [   $ SizeToHeader 6k   	 6;   �� $
 Suffix�6k     5      -	   5        companyColumn��$ Company��5   ]   $ SizeToHeader 6n   	 6<   �� $
 Company�6n     5      -
   5        salesPersonColumn��$ Sales Person��5   e   $ SizeToHeader 6{   	 6@   �� $
 SalesPerson�6{     5      -   5        emailAddressColumn��$ Email Address��5   g   $ SizeToHeader 6~   	 6A   �� $
 EmailAddress�6~     5      -   5        phoneColumn��$ Phone��5   Y   $ SizeToHeader 6h   	 6:   �� $
 Phone�6h   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        modifiedDateColumn��$ Modified Date��5   E   $ SizeToHeader 6\      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� $
 ModifiedDate� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . 5      5      5      5      5      