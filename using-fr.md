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
   <th>Format de valeur<th>
   <tr>
       <td>content</td>
       <td>&lsaquo;param name="content" value="Contenu de la notification"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
   </tr>
   <tr>
       <td>title</td>
       <td>&lsaquo;param name="title" value="Titre de la notification"/&rsaquo;</td>
       <td>""</td>
       <td>String</td>
   </tr>
   <tr>
       <td>backgroundColor</td>
       <td>&lsaquo;param name="backgroundColor" value="Titre de la notification"/&rsaquo;</td>
       <td>"#1F1F1F"</td>
       <td>HTML hexadecimal code</td>
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
