<h1>Utilisation de Kubeah_SimpleNotification.dll</h1>
<br>
<h4>L'application utilise des fichier au format XML.
<br>
Les paramètres sont listés ci-dessous.
<br>
Le nom et l'extension du fichier n'ont pas d'importance car l'application prend le dernier fichier créé dans le répertoire concerné.
</h4>
<br></br>

<h3>Fichier XML - Paramètres</h3>
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
       <td>time</td>
       <td>&lsaquo;param name="time" value="10"/&rsaquo;</td>
       <td>"5"</td>
       <td>Int (secondes)</td>
      <td>Durée de l'affichage en seconde</td>
   </tr>
</table>
<br>
<br>
<h3>Exemple de fichier XML</h3>
<p>
   &lsaquo;?xml version="1.0" encoding="utf-8"?&rsaquo;
   <br>
   &lsaquo;param&rsaquo;
   <br>
      &emsp;&emsp;&lsaquo;param name="content" value="Contenu de la notification"/&rsaquo;
   <br>
      &emsp;&emsp;&lsaquo;param name="title" value="Titre de la notification"/&rsaquo;
   <br>
   &lsaquo;/param&rsaquo;
</p>
<br>
<br>
<h3>Notifications - Paramètres</h3>
<h5>./NotificationApp.conf - Fichier format XML</h5>
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
       <td>notificationFolder</td>
       <td>&lsaquo;param name="notificationFolder" value=".\\temp\Notifications"/&rsaquo;</td>
       <td>".\\Notifications"</td>
       <td>String</td>
      <td>Chemin du dossier notification</td>
   </tr>
</table>
