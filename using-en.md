<h1>English Documentation - Kubeah_SimpleNotification</h1>
<br>
<h4>
For each new notification, it is necessary to run the application. The application always takes the last XML notification file created.
<br>
<br>
The application uses XML files to create notifications.
<br>
The parameters are <a href="#notification">listed below</a>.
<br>
The name and extension of the XML files are not important because the application takes the last file created in the directory concerned.
</h4>
<br>
<h3 id="notification">XML File (Notification) - Parameters</h3>
<a href="https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/notification_sample.xml">Notification file example.</a>
<br>
<table>
   <th>Parameter</th>
   <th>Example of use</th>
   <th>Default value</th>
   <th>Value format</th>
   <th>Information</th>
   <tr>
       <td>content</td>
       <td>&lsaquo;param name="content" value="Contenu de la notification"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
      <td>Content</td>
   </tr>
   <tr>
       <td>title</td>
       <td>&lsaquo;param name="title" value="Titre de la notification"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
      <td>Title</td>
   </tr>
   <tr>
       <td>backgroundColor</td>
       <td>&lsaquo;param name="backgroundColor" value="#000102"/&rsaquo;</td>
       <td>"#1F1F1F"</td>
       <td>HTML hexadecimal code</td>
      <td>Background color</td>
   </tr>
   <tr>
       <td><i>opacity (Next release)</i></td>
       <td>&lsaquo;param name="opacity" value="0,8"/&rsaquo;</td>
       <td>"1,0"</td>
       <td>Double (0,0 à 1,0)</td>
      <td>Opacity of the notification. Values are written with a comma.</td>
   </tr>
   <tr>
       <td>fontColor</td>
       <td>&lsaquo;param name="fontColor" value="#000102"/&rsaquo;</td>
       <td>"#FFF"</td>
       <td>HTML hexadecimal code</td>
      <td>Text color</td>
   </tr>
   <tr>
       <td>time</td>
       <td>&lsaquo;param name="time" value="10"/&rsaquo;</td>
       <td>"5"</td>
       <td>Int (secondes)</td>
      <td>Display duration in seconds</td>
   </tr>
   <tr>
       <td><i>iconPath (Prochaine release)</i></td>
       <td>&lsaquo;param name="iconPath" value="./img.png"/&rsaquo;</td>
       <td>""</td>
       <td>String (Chemin de fichier)</td>
      <td>Icon of the notification. The images are in 32x32 format</td>
   </tr>
</table>
<br>
<br>
<br>
<h3>Application Settings</h3>
<h5>./NotificationApp.conf - XML format file</h5>
<br>
<a href="https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/NotificationApp.conf">Example of a configuration file</a>
<table>
   <th>Parameter</th>
   <th>Example of use</th>
   <th>Default value</th>
   <th>Value format</th>
   <th>Information</th>
   <tr>
       <td>logsEnable</td>
       <td>&lsaquo;param name="logEnable" value="true"/&rsaquo;</td>
       <td>"false"</td>
       <td>Boolean</td>
      <td>Displaying logs in the file".\Notification.log"</td>
   </tr>
   <tr>
       <td>notificationsFolder</td>
       <td>&lsaquo;param name="notificationFolder" value=".\\temp\Notifications"/&rsaquo;</td>
       <td>".\\Notifications"</td>
       <td>String</td>
      <td>Path to the notification file</td>
   </tr>
   <tr>
       <td>styleFile</td>
       <td>&lsaquo;param name="styleFile" value=".\\styleNotification.xml"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
      <td>Notification style file path
      <br>
         !!! Attention see below
      </td>
   </tr>
   <tr>
       <td>saveNotifications</td>
       <td>&lsaquo;param name="saveNotifications" value="true"/&rsaquo;</td>
       <td>"false"</td>
       <td>Boolean</td>
      <td>File retention after the file is displayed</td>
   </tr>
</table>
<br>
<h3>Style XML file</h3>
<a href="https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/NotificationsStyle.xml">Example of a style file</a>
<p>This file is used to avoid having to reset the same parameters in different files each time.</p>
<p>Usage: In the application configuration file, it is necessary to indicate the path of the application.
<br>
    Warning : The configuration in this file takes precedence over the configuration in the <a href="#notification">XML notification file</a>.

<br>
   The parameters are the same as those of the XML notification file.
</p>
