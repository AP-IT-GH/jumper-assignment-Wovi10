# Jumper game: how to
## Clonen
### Command prompt
Hieronder vind je de uitleg nodig om je het project te clonen via git veronderstellende dat je git al hebt.

1.  Open je cmd door cmd te typen in je start menu.
2.  Type cd "de folder waar je het project in wilt clonen"
3.  Type git clone https://github.com/AP-IT-GH/jumper-assignment-Wovi10
4.  Nu zou git alle bestanden moeten downloaden en is je project start klaar om te openen met unity(2020.3.23f1)


### Github Desktop
Hieronder vind je de uitleg nodig om je het project te clonen via GitHub Desktop.  

1.	Kopiëer volgende link: https://github.com/AP-IT-GH/jumper-assignment-Wovi10.git
2.	Open GitHub Desktop
3.	Onder 'file' kiest u 'Clone a repository'
4.	Kies URL en plak je URL in het URL-veld
5.	Druk op 'clone' en klaar is kees

## Open het project
Laat ons het project openen.

1.	Open Unity Hub en klik op 'Add'
<img src="src\UnityHub.png" width="75%" height="auto">

2.	Ga naar de folder waar je je GitHub project hebt gezet en selecteer deze
3.	Open het project door er op te drukken

## Start het project
Om het voor u makkelijk te maken hebben we het getrainde brein in de folder gezet, deze heet "Jumper".
Hier moet u echter niets aan doen aangezien we deze al hebben ingesteld.
Het enige u moet doen is op play drukken.  
<img src="src\UnityPlay.png" width="75%" height="auto">

Als het toch niet blijkt te werken kan u volgende stappen proberen:"
1.	Zorg dat onderaan in het project venster je in de folder Assets/Brain staat
2.	Links op het scherm ziet u de Hierarchy van de "Jumper scene", hier klikt u op "===== Environments ====="
3.	Klik op "Environment"
4.	Duid VelociPlayer aan, er opent rechts een Inspector venster  
<img src="src\velociPlayer.png" width="auto" height="auto">  

5.	Ga naar de behavior parameters
6.	Sleep het Jumper file naar "Model"
7.	Zet Behavior type op "Inference only"  
<img src="src\Model.png" width="auto" height="auto"> 
 
8.	Nu kan u op play drukken

## Zelf brein trainen
We gaan er vanuit dat je een anaconda environment hebt met mlagents geïnstalleerd.
1.  Open "===== Environments ====="
2.  Open "Environment"
3.  Klik op "VelociPlayer"
4.  Ga naar de behavior parameters
5.  Bij model zie je inference device en dit moet op Default staan
6.  Open anaconda en open je mlagents environment
<img src="src\Anaconda.png" width="75%" height="auto">

7.  Ga naar de folder "Training" in "Assets" in het path waar je je project hebt gecloned via het cd commando.
8.  Als je hier met je file explorer naartoe gaat zie je een Jumper.yaml file staan.
9.  In deze file kan je eventueel met hyperparameters spelen. Hier meer over in deze link: https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Configuration-File.md#ppo-specific-configurations
10. Nu verder in anaconda. Met het commando "mlagents-learn Jumper.yaml --run-id [Een naam dat je zelf kiest]" zet je pytorch klaar om het leren te starten(de "run-id" moet zonder de "[" en "]"). Hieronder zie je een foto van hoe je commandprompt er zou moeten uitzien.  
<img src="src\Training.png" width="75%" height="auto">

11. In unity moet je op play duwen en zo start je het trainings proces.


## Waarom werkt het niet?
Als u het getrainde neuraal netwerk laat lopen, merkt u dat die niet mooi over de cactussen springt.
Dit komt omdat we tijdens de training altijd op het punt kwamen waar de agent denkt dat blijven staan beter is dan springen.
Tijdens de training springt hij namelijk een aantal keren over de cactus en merkt dat dit goed is, maar dan loopt het fout omdat hij te vaak op de cactus land en denkt dat niet springen dus beter is.  
We hebben een aantal zaken geprobeerd zoals het aanpassen van:
-	De raylength
-	De learning rate
-	De Curiousity strength
-	De rewards
-	De end/start vertical offset
-	De Sphere cast radius

Niets leek echter te helpen, we merkten wel dat een ray length van 27 het dichtste bij optimaal kwam.