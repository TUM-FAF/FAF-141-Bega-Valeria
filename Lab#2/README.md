Completed Tasks:

- Create a Windows application what will dispaly a dialog box on some event (ex. on clicking some button)
To create a popup dialog box, before we create one in the source file(rc.file).The AboutDIgProc() was created - the function that will do 
the displaying of the dialog box.It appears when I press the More option from the menu.

- Add a system menu to your application with at least 3 items (add actions to that items)
The menu was also created in the source file.Popup defines a menu item,Menuitem defines a submenu item.Three items were created: File, 
More and About, each with different submenu items

- Hook keyboard input. Add 2 custom events for 2 different keyboard combinations (ex. change window background on ctrl+space)
Hooks : CTRL + W for exiting from the application, and CTRL + I for displaying a dialog box. These actions are managed in the WMHOTKEY 
case.

- Add a scroll bar that will change any visible parameter of any other element (color of a text) OR other 2 scroll bars that will manage
main window size or position
I've created a scrollbar using CreateWindowEx() by specifying the 2nd parameter as "SCROLLBAR" and a xPos variable that is changing the
way messages in the WMHSCROLL are called. Color of the text is changing by using the SetTextColor() function together with xPos variable.

- Customize your application by adding an icon and using different cursor in application
I added in the main folder where the main.cpp is located a custom cursos and icon, you can see the cool icon of a magic hat.
Then they are declared in source file respectively.

-Add a listbox and attach some events when any element is accessed (clicked)
I've created the listbox using CreateWindowEx() by specifying the 2nd parameter as "LISTBOX". Elements in the listbox are added from the 
interaction between an editbox and a button. When an element from listbox is double-clicked, a messagebox with the name of selected 
element is displayed; when on a selected element from listbox is pressed right click, an alert is displayed about deleting the selected
element. (this is done in the WMCONTEXTMENU case. )


