<h1>Documentation Française - Kubeah_SimpleNotification</h1>
<br>
<h4>
Pour chaque nouvelle notification, il est nécessaire d'exécuter l'application. L'application prend toujours le dernier fichier XML de notification créée.
<br>
<br>
L'application utilise des fichier au format XML pour la création des notifications.
<br>
Les paramètres sont <a href="#notification">listés ci-dessous</a>.
<br>
Le nom et l'extension des fichiers XML n'ont pas d'importance car l'application prend le dernier fichier créé dans le répertoire concerné.
</h4>
<br>
<h3 id="notification">Fichier XML (Notification) - Paramètres</h3>
<a href="https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/notification_sample.xml">Exemple d'un fichier de notification</a>
<br>
<table>
   <th>Paramètre</th>
   <th>Exemple d'utilisation</th>
   <th>Valeur par défault</th>
   <th>Format de valeur</th>
   <th>Information</th>
   <tr>
       <td>content</td>
       <td>&lsaquo;param name="content" value="Contenu de la notification"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
      <td>Contenu</td>
   </tr>
   <tr>
       <td>title</td>
       <td>&lsaquo;param name="title" value="Titre de la notification"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
      <td>Titre</td>
   </tr>
   <tr>
       <td>backgroundColor</td>
       <td>&lsaquo;param name="backgroundColor" value="#000102"/&rsaquo;</td>
       <td>"#1F1F1F"</td>
       <td>HTML hexadecimal code</td>
      <td>Couleur de l'arrière-plan</td>
   </tr>
   <tr>
       <td><i>opacity (Prochaine release)</i></td>
       <td>&lsaquo;param name="opacity" value="95"/&rsaquo;</td>
       <td>"0"</td>
       <td>Int</td>
      <td>Opacité de la notification</td>
   </tr>
   <tr>
       <td>fontColor</td>
       <td>&lsaquo;param name="fontColor" value="#000102"/&rsaquo;</td>
       <td>"#FFF"</td>
       <td>HTML hexadecimal code</td>
      <td>Couleur du texte</td>
   </tr>
   <tr>
       <td>time</td>
       <td>&lsaquo;param name="time" value="10"/&rsaquo;</td>
       <td>"5"</td>
       <td>Int (secondes)</td>
      <td>Durée de l'affichage en seconde</td>
   </tr>
   <tr>
       <td><i>iconPath (Prochaine release)</i></td>
       <td>&lsaquo;param name="iconPath" value="./img.png"/&rsaquo;</td>
       <td>""</td>
       <td>String (Chemin de fichier)</td>
      <td>Icon de la notification. Les images sont au format 32x32</td>
   </tr>
</table>
<br>
<br>
<br>
<h3>Paramètres de l'application</h3>
<h5>./NotificationApp.conf - Fichier format XML</h5>
<br>
<a href="https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/NotificationApp.conf">Exemple d'un fichier de configuration</a>
<table>
   <th>Paramètre</th>
   <th>Exemple d'utilisation</th>
   <th>Valeur par défault</th>
   <th>Format de valeur</th>
   <th>Information</th>
   <tr>
       <td>logsEnable</td>
       <td>&lsaquo;param name="logEnable" value="true"/&rsaquo;</td>
       <td>"false"</td>
       <td>Boolean</td>
      <td>Affichage des logs dans le fichier ".\Notification.log"</td>
   </tr>
   <tr>
       <td>notificationsFolder</td>
       <td>&lsaquo;param name="notificationFolder" value=".\\temp\Notifications"/&rsaquo;</td>
       <td>".\\Notifications"</td>
       <td>String</td>
      <td>Chemin du dossier notification</td>
   </tr>
   <tr>
       <td>styleFile</td>
       <td>&lsaquo;param name="styleFile" value=".\\styleNotification.xml"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
      <td>Chemin fichier de style des notifications
      <br>
         !!! Attention voir en dessous
      </td>
   </tr>
   <tr>
       <td>saveNotifications</td>
       <td>&lsaquo;param name="saveNotifications" value="true"/&rsaquo;</td>
       <td>"false"</td>
       <td>Boolean</td>
      <td>Conservation des fichiers après l'affichage de celui-ci</td>
   </tr>
</table>
<br>
<h3>Fichier XML de style</h3>
<a href="https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/NotificationsStyle.xml">Exemple d'un fichier de style</a>
<p>Ce fichier est utilisé pour ne pas avoir besoin de remettre à chaque fois les mêmes paramètres dans les différents fichiers.</p>
<p>Utilisation : Dans le fichier de configuration de l'application, il est nécessaire d'indiquer le chemin de celui-ci.
<br>
   Attention : La configuration présente dans ce fichier prime sur celle présente sur les <a href="#notification">fichier XML de notification</a>.

<br>
   Les paramètres sont les mêmes que ceux du fichier XML de notification.
</p>
