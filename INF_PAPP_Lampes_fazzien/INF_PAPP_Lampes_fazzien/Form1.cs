/*Nom: Fazzi Enzo
 *Date: 26.01.17
 *But: Jeu des lampes: Chaque joueurs à le droit de cliquer jusqu'à 3 fois maximum sur lampe mais une obligatoirement. 
 *Le joueur qui clique sur la dernière lampes, a perdu.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace INF_PAPP_Lampes_fazzien
{
    /*Nom: Fazzi Enzo
     *Date: 26.1.17
     *But: Déclaration de toutes les variables
     */
    public partial class int_lampes : Form
    {
        int x = 0;//variable qui parcourt le tableau dans une boucle for de 0 à 19 dans le cas ou int_colonne est à 20
        int tour = 3;//nombre max de clics
        int cpt = 1;//Nombre de clics
        int player = 0;//Quel joueur joue (clic)        
        int int_colonnes = 20;//variable de 20 colonnes dans le tableau
        int nbslampeseteinte = 0;//Le nombre de lampe éteinte
        int musique = 0;//La musique = 0 (Pas de musique)
        SoundPlayer music1 = new SoundPlayer("Kyla-La-Grange_Cut-Your-Teeth_Kygo_Remix.wav");
        SoundPlayer music2 = new SoundPlayer("Survivor_Eye-Of-The-Tiger.wav");
        const int maxcase = 50;//max de case dans le tableau "Btn_TabListe[]"$
        Button clickedButton;
        Label lbl_aide = new Label();
        Button[] Btn_TabListe = new Button[maxcase];//Déclaration du tableau unidimentionnel
        DateTime TempsActuel;//Récupère l'heure tous les 100 centièmes de secondes
        TimeSpan TempsPasse;//Fait la différence de temps passé entre le click du bouton "Démarrer" et le temps actuel
        DateTime TempsDepart;//Récupère l'heure quand on appuie sur le bouton "Démarrer"        
        Image LampeEteinte = Image.FromFile("LampeEteinteProjetCommun.png");//Lampe éteinte = va chercher l'image adéquoite dans le dossier
        Image LampeAllumee = Image.FromFile("LampeAllumeeProjetCommun.png");//Lampe allumee = va chercher l'image adéquoite dans le dossier

        /*Nom: Fazzi Enzo
         *Date: 26.01.17
         *But: Affiche tout dans le panel
         */
        public int_lampes()
        {
            InitializeComponent();//Apparition Initiale:...;
            lampes();//...Nom de la fonction "Appel de fonction"...
            lbl_min.Text = "00";//..."00"...
            lbl_2pts_min.Text = " : ";//...":"...
            lbl_sec.Text = "00";//..."00"...
            lbl_2pts_sec.Text = " : ";//...":"...
            lbl_msec.Text = "00";//..."00"
            txt_player1.Text = "";//Efface le nom du joueur 1
            txt_player2.Text = "";//Efface le nom du joueur 2
            lbl_player1.BackColor = Color.GreenYellow;//Met un fond de couleur dans le label du joueur 1
            lbl_player2.BackColor = Color.Yellow;//Met un fond de couleur dans le label du joueur 2
            for (x = 0; x < int_colonnes; x++)//Tant que x est plus petit que 20...
            {
                Btn_TabListe[x].BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//...je transforme l'image en une lampe éteinte
                pnl_Grille.Enabled = true;//Active la grille (affiche)               
            }//Fin for
        }//Fin int_lampes()

        /*Nom: Fazzi Enzo
         *Date: 27.01.17
         *But: Initialise tout ce qui y'a dans le tableau (ici, les grise)
         */
        private void Tableau_Load(object sender, EventArgs e)
        {
            Timer_Chrono.Enabled = false;//Stop le Chrono au démarrage du programme
            btn_valider.Enabled = false;//Grise le bouton "Valider" au démarrage du programme
            btn_demarrer.Enabled = false;//Grise le bouton "Démarrer" au Démarrage pour permettre l'écriture du nom des joueurs
            pnl_Grille.Enabled = false;//Grise tous les boutons au démarrage
        }//Fin Tableau_Load

        /*Nom: Fazzi Enzo
         *Date: 26.01.17
         *But: Créer le tableau unidimensionnel
         */
        private void lampes()
        {
            int intCote = pnl_Grille.Width / int_colonnes;//largeur de la grille / les colonnes = taille d'une case

            for (x = 0; x < int_colonnes; x++)//boucle for qui défini x (parcours les colonnes du tableau) à 0 et qui l'incrémente tant que c'est plus petit que 20
            {
                Btn_TabListe[x] = new Button();//Ajoute un/des nouveau/x bouton/s

                pnl_Grille.Controls.Add(Btn_TabListe[x]);//Mettre le tableau dans le panel Design

                Btn_TabListe[x].Size = new Size(intCote, intCote);//Défini la taille du tableau
                Btn_TabListe[x].Left = x * intCote;//Défini la localisation du boutton depuis la gauche, ici sa place * sa taille
                Btn_TabListe[x].Top = 0;//Défini la localisation du bouton depuis le haut
                Btn_TabListe[x].Click += new EventHandler(BtnTest_Click);//Création de la fonction "BtnTest_Click"
                Btn_TabListe[x].MouseHover += new System.EventHandler(btn_MouseHover);
                Btn_TabListe[x].BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//Parcours toutes les cases du tableau et les transforment en lampe éteintes
            }//Fin boucle for
        }//Fin private void Tableau();

        /*Nom: Fazzi Enzo
         *Date: 27.01.17
         *But: Dès que je clic sur un bouton du tableau, j'execute ses commandes
         */
        public void BtnTest_Click(object sender, EventArgs e)
        {
            clickedButton = (Button)sender;//Création d'une variable
            clickedButton.BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//Dès que je clique sur le bouton, elle devient une lampe éteinte
            
            clickedButton.Enabled = false;//Grise le bouton qui vient d'être cliqué
            
            for (x = 0; x < int_colonnes; x++)//tant que x est plus petit que 20, je rentre dans le for
            {   //Si c'est une lampe éteinte (désactivée)
                if (Btn_TabListe[x].Enabled == false)//Si le 1er bouton afficher est = a grisé...
                {
                    nbslampeseteinte++;//...j'incrémente de 1
                }//Fin if
            }//Fin for
            if (nbslampeseteinte == int_colonnes)//Si le nombre de lampes éteinte est = aux nombres de colonnes
            {
                if (player == 0)//Si player est = 0
                {
                    lbl_player1.BackColor = Color.White;//Colore le fond du label du joueur 2 en blanc
                    lbl_player2.BackColor = Color.Yellow;//Colore le fond du label du joueur 2 en blanc
                    player++;//incrémante de 1 (=joueur 2)
                }//Fin if
                else
                {
                    lbl_player2.BackColor = Color.White;//Colore le fond du label du joueur 1 en blanc
                    lbl_player1.BackColor = Color.GreenYellow;//Colore le fond du label du joueur 1 en vert citron
                    player--;//incrémante de 1 (=joueur 1)
                }//Fin else
                Timer_Chrono.Stop();//Arret du Chrono                 
                if (lbl_player1.BackColor == Color.GreenYellow)//Si la couleur du label est = a vert citron
                {
                    clickedButton.BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//Dès que je clique sur le bouton, elle devient une lampe éteinte
                    clickedButton.Enabled = false;//Grise le bouton qui vient d'être cliqué
                    btn_valider.Enabled = false;//Grise le bouton valider
                    btn_demarrer.Enabled = false;//Grise le bouton Démarrer (Réinitialiser)
                    lbl_player1.BackColor = Color.White;//Colore le fond du label du joueur 1 en blanc
                    lbl_player2.BackColor = Color.Yellow;//Colore le fond du label du joueur 1 en jaune
                    MessageBox.Show(txt_player2.Text + " a perdu en " + lbl_min.Text + " minute(s), " + lbl_sec.Text + " seconde(s) et " + lbl_msec.Text + " centième(s)");//...affiche le nom du joueur 1 qui perd et en combien de temps il a perdu
                    btn_valider.Enabled = false;//Grise le bouton valider   

                    btn_demarrer.Text = "Démarrer";//Bouton "Démarrer" reste "Démarrer"
                    btn_valider.Enabled = false;//Bouton "Valider" grisé
                    btn_demarrer.Enabled = true;//Bouton "Démarrer" visible
                    Timer_Chrono.Stop();//Arret du Chrono
                    lbl_min.Text = "00";//"00"
                    lbl_2pts_min.Text = " : ";//":"
                    lbl_sec.Text = "00";//"00"
                    lbl_2pts_sec.Text = " : ";//":"
                    lbl_msec.Text = "00";//"00"
                    txt_player1.Text = "";//"Efface" le texte entrer dans la textbox "txt_player1"
                    txt_player2.Text = "";//"Efface" le texte entrer dans la textbox "txt_player2"
                    pnl_Grille.Enabled = false;//Toute la grille se grise
                    txt_player1.Enabled = true;//Affichage du label du joueur 1
                    txt_player2.Enabled = true;//Affichage du label du joueur 2
                    lbl_player1.BackColor = Color.GreenYellow;//Le fond de couleur du texte du joueur 1 devient blanc
                    lbl_player2.BackColor = Color.Yellow;//Le fond de couleur du texte du joueur 2 devient blanc
                    cpt = 1;//Le compteur est réinitialisé à 1
                    player = 0;//player = 0   =   Joueur 1
                    for (x = 0; x < int_colonnes; x++)//Tant que x est plus petit que int_colonnes...
                    {
                        Btn_TabListe[x].BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//...Réinitialise les bontons en lampe éteinte
                    }//Fin for
                }//Fin if
                else
                {
                    clickedButton.BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//Dès que je clique sur le bouton, elle devient une lampe éteinte
                    clickedButton.Enabled = false;//Grise le bouton qui vient d'être cliqué
                    btn_valider.Enabled = false;//Grise le bouton valider
                    btn_demarrer.Enabled = false;//Grise le bouton Démarrer (Réinitialiser)
                    lbl_player2.BackColor = Color.White;//Colore le fond du label du joueur 2 en blanc
                    lbl_player1.BackColor = Color.GreenYellow;//Colore le fond du label du joueur 1 en vert citron
                    MessageBox.Show(txt_player1.Text + " a perdu en " + lbl_min.Text + " minute(s), " + lbl_sec.Text + " seconde(s) et " + lbl_msec.Text + " centième(s)");//...affiche le nom du joueur 2 qui perd et en combien de temps il a perdu
                    btn_valider.Enabled = false;//Grise le bouton valider

                    btn_demarrer.Text = "Démarrer";//Sinon, bouton "Démarrer" reste "Démarrer"
                    btn_valider.Enabled = false;//Bouton "Valider" grisé
                    btn_demarrer.Enabled = true;//Bouton "Démarrer" visible
                    Timer_Chrono.Stop();//Arret du Chrono
                    lbl_min.Text = "00";//"00"
                    lbl_2pts_min.Text = " : ";//":"
                    lbl_sec.Text = "00";//"00"
                    lbl_2pts_sec.Text = " : ";//":"
                    lbl_msec.Text = "00";//"00"
                    txt_player1.Text = "";//"Efface" le texte renter dans la textbox "txt_player1"
                    txt_player2.Text = "";//"Efface" le texte rentre dans la textbox "txt_player2"
                    pnl_Grille.Enabled = false;//Toute la grille se grise
                    txt_player1.Enabled = true;//Affichage du label du joueur 1
                    txt_player2.Enabled = true;//Affichage du label du joueur 2
                    lbl_player1.BackColor = Color.GreenYellow;//Le fond de couleur du texte du joueur 1 devient blanc
                    lbl_player2.BackColor = Color.Yellow;//Le fond de couleur du texte du joueur 2 devient blanc
                    cpt = 1;//Le compteur est réinitialisé à 1
                    player = 0;//player = 0   =   Joueur 1
                    for (x = 0; x < int_colonnes; x++)//Tant que x est plus petit que int_colonnes...
                    {
                        Btn_TabListe[x].BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//...Réinitialise les bontons en lampe éteinte
                    }//Fin for
                }//Fin else
            }//Fin if
            else
            {
                nbslampeseteinte = 0;//Défini le nombre de lampe éteinte en 0

                if (cpt == tour)//Si le compteur nombre de clic est = au nombre max de clics
                {
                    pnl_Grille.Enabled = true;//j'active toute la grille
                    cpt = 1;//Compteur réinitialiser à 1
                    btn_valider.Enabled = false;//je désactive le bouton valider

                    if (player == 0)//Si joueur = 0 "0 = joueur 1"
                    {
                        lbl_player1.BackColor = Color.White;//...je colore le label du joueur 1 en blanc...
                        lbl_player2.BackColor = Color.Yellow;//...et je colore la label du joueur 2 en jaune...
                        player++;//...j'incrémente le joueur de 1 "player++ = player devient le joueur 2
                        btn_valider.Enabled = false;
                    }//Fin if
                    else
                    {
                        lbl_player2.BackColor = Color.White;//...je colore le label du joueur 2 en blanc...
                        lbl_player1.BackColor = Color.GreenYellow;//...et je colore le label du joueur 1 en vert citron...
                        player--;//...j'enleve 1 au player "player-- = player deveint le joueur 1
                        btn_valider.Enabled = false;
                    }//Fin else
                    cpt = 1;//compteur est = 1
                }//Fin if
                else
                {
                    cpt++;//incrémente de 1 le compteur
                    btn_valider.Enabled = true;//Dégrise le bouton valider
                }//Fin else
            }//Fin else
            pnl_Grille.Cursor = Cursors.No;
        }//Fin BtnTest_Click

        /*Nom: Fazzi Enzo
         *Date: 27.01.17
         *But: Dès que je clic sur le bouton Démarrer, j'exectute ses commandes
         */
        public void btn_demarrer_Click(object sender, EventArgs e)//Quand je clique sur le bouton "Démarrer"...s'affichent            
        {
            if (txt_player1.Text == txt_player2.Text)//Si le nom du joueur 1 est le même que celui du joueur 2, affiche une messagebox et efface le nom du joueur 2
            {
                btn_demarrer.Enabled = false;//Grise le bouton Démarrer                
                MessageBox.Show("Veuillez changez le nom du joueur 2");//Affiche une messagebox
                txt_player2.Text = ("");//Texte du joueur 2 deveint vide
            }
            else if (btn_demarrer.Text == "Démarrer" )//Si bouton "Démarrer" = "Démarrer"...
            {
                btn_demarrer.Text = "Réinitialiser";//...je le transforme en "Réinitialiser"...
                TempsDepart = DateTime.Now;//Récupère l'heure de départ
                Timer_Chrono.Start();//Met le chrono en marche
                pnl_Grille.Enabled = true;//Affiche le panel
                txt_player1.Enabled = false;//...le nom du joueur 1 se grise...
                txt_player2.Enabled = false;//...le nom du joueur 2 se grise...
                lbl_player2.BackColor = Color.White;//...le fond de couleur du label du joueur 2 devient blanc...
                for (x = 0; x < int_colonnes; x++)//Tant que x est plus petit que int_colonnes...
                {
                    Btn_TabListe[x].BackgroundImage = new Bitmap("LampeAllumeeProjetCommun.png");//...Remplace tous les boutons de lampe éteinte en lampe allumée
                    Btn_TabListe[x].Enabled = true;//Les boutons sont visible
                }//Fin for

            }//Fin if
            else
            {
                btn_demarrer.Text = "Démarrer";//Sinon, bouton "Démarrer" reste "Démarrer"
                btn_valider.Enabled = false;//Bouton "Valider" grisé
                btn_demarrer.Enabled = true;//Bouton "Démarrer" visible
                Timer_Chrono.Stop();//Arret du Chrono
                lbl_min.Text = "00";//"00"
                lbl_2pts_min.Text = " : ";//":"
                lbl_sec.Text = "00";//"00"
                lbl_2pts_sec.Text = " : ";//":"
                lbl_msec.Text = "00";//"00"
                txt_player1.Text = "";//"Efface" le texte renter dans la textbox "txt_player1"
                txt_player2.Text = "";//"Efface" le texte rentre dans la textbox "txt_player2"
                pnl_Grille.Enabled = false;//Toute la grille se grise
                txt_player1.Enabled = true;//Affichage du label du joueur 1
                txt_player2.Enabled = true;//Affichage du label du joueur 2
                lbl_player1.BackColor = Color.GreenYellow;//Le fond de couleur du texte du joueur 1 devient blanc
                lbl_player2.BackColor = Color.Yellow;//Le fond de couleur du texte du joueur 2 devient blanc
                cpt = 1;//Le compteur est réinitialisé à 1
                player = 0;//player = 0   =   Joueur 1
                btn_music.Visible = false;//Le bouton pour la musique n'est pas visible
                music1.Stop();//Stop la musique 1
                music2.Stop();//Stop la musique 2
                musique = 0;//Revient sur Musique OFF
                btn_music.Text = ("OFF");//Change le texte du bouton en "OFF"
                for (x = 0; x < int_colonnes; x++)//Tant que x est plus petit que int_colonnes...
                {
                    Btn_TabListe[x].BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//...Réinitialise les bontons en lampe éteinte
                }//Fin for

            }//Fin else
        }//Fin btn_demarrer_Click

        /*Nom: Fazzi Enzo
         *Date: 30.01.17
         *But: Création du chrono
         */
        private void Timer_Chrono_Tick(object sender, EventArgs e)
        {
            TempsActuel = DateTime.Now;//Récupère l'heure actuelle
            TempsPasse = TempsActuel - TempsDepart; //-tempsPause
            lbl_min.Text = (TempsPasse.Minutes).ToString("0#");//Permet le démarrage du chrono
            lbl_sec.Text = (TempsPasse.Seconds).ToString("0#");//Permet le démarrage du chrono
            lbl_msec.Text = (TempsPasse.Milliseconds / 10).ToString("0#");//Permet le démarrage du chrono et divise les milliseconde par 10
        }//Fin public void Timer_Chrono_Tick

        /*Nom: Fazzi Enzo
         *Date: 02.02.17
         *But: Cette fonction permet de ne pas pouvoir démarrer le jeu sans avoir mis de nom dans les Textbox
         */
        private void txt_player1_TextChanged(object sender, EventArgs e)
        {
            if (txt_player1.Text == "" || txt_player2.Text == "")//Si le texte du joueur 1 est = "rien"... ou si le texte du joueur 2 est = "rien"...
            {
                btn_demarrer.Enabled = false;//...je désactive le bouton démarrer
            }//Fin if
            else
            {
                btn_demarrer.Enabled = true;//...j'active le bouton démarrer
            }//Fin else
        }//Fin txt_player1_TextChanged

        /*Nom: Fazzi Enzo
         *Date: 02.02.17
         *But: Cette fonction permet de ne pas pouvoir démarrer le jeu sans avoir mis de nom dans les Textbox
         */
        private void txt_player2_TextChanged(object sender, EventArgs e)
        {
            if (txt_player1.Text == "" || txt_player2.Text == "")//Si le texte du joueur 1 est = "rien"... ou si le texte du joueur 2 est = "rien"...
            {
                btn_demarrer.Enabled = false;//...je désactive le bouton démarrer
            }//Fin if
            else
            {
                btn_demarrer.Enabled = true;//...j'active le bouton démarrer                
            }//Fin else
        }//Fin txt_player2_TextChanged

        /*Nom: Fazzi Enzo
         *Date: 31.01.17
         *But: Dès que je clic sur le bouton Valider, j'exectute ses commandes
         */
        private void btn_valider_Click(object sender, EventArgs e)
        {
            pnl_Grille.Enabled = true;//j'active toute la grille (bouton compris)
            cpt = 1;//Compteur réinitialiser à 1
            btn_valider.Enabled = false;//je désactive le bouton valider
            if (player == 0)//Si joueur = 0 "0 = joueur 1"
            {
                lbl_player1.BackColor = Color.White;//...je colore le label du joueur 1 en blanc...
                lbl_player2.BackColor = Color.Yellow;//...et je colore la label du joueur 2 en jaune...
                player++;//...j'incrémente le joueur de 1 "player++ = player devient le joueur 2
            }
            else
            {
                lbl_player2.BackColor = Color.White;//...je colore le label du joueur 2 en blanc...
                lbl_player1.BackColor = Color.GreenYellow;//...et je colore le label du joueur 1 en vert citron...
                player--;//...j'enleve 1 au player "player-- = player deveint le joueur 1
            }//Fin else
        }//Fin btn_valider_Click

        /*Nom: Fazzi Enzo
         *Date: 02.02.17
         *But: Permet d'appuyer sur un bouton Aide qui donne les règles du jeu
         */
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                                              Règles du jeu:" + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Etape 1: Chaques joueurs doit entrer son nom." + Environment.NewLine + Environment.NewLine + "Etape 2: Démarrer le jeu puis, le 1er joueur doit cliquer sur minimun 1 case pour continuer le jeu. Chaque joueurs à droit à minimum 1 clic jusqu'à max 3 clics pour valider son tour." + Environment.NewLine + Environment.NewLine + "Etape 3: Le joueur qui clic sur la dernière lampe, perd la partie.");            
        }//Fin aideToolStripMenuItem_Click

        /*Nom: Fazzi Enzo
         *Date: 02.02.17
         *But: Permet la même commande que je bouton Réinitialiser mais dans le bouton Réinitialiser dans le menu contextuel
         */
        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_demarrer.Text = "Démarrer";//Sinon, bouton "Démarrer" reste "Démarrer"
            btn_valider.Enabled = false;//Bouton "Valider" grisé
            btn_demarrer.Enabled = false;//Bouton "Démarrer" visible
            Timer_Chrono.Stop();//Arret du Chrono
            lbl_min.Text = "00";//"00"
            lbl_2pts_min.Text = " : ";//":"
            lbl_sec.Text = "00";//"00"
            lbl_2pts_sec.Text = " : ";//":"
            lbl_msec.Text = "00";//"00"
            txt_player1.Text = "";//"Efface" le texte renter dans la textbox "txt_player1"
            txt_player2.Text = "";//"Efface" le texte rentre dans la textbox "txt_player2"
            pnl_Grille.Enabled = false;//Toute la grille se grise
            txt_player1.Enabled = true;//Affichage du label du joueur 1
            txt_player2.Enabled = true;//Affichage du label du joueur 2
            lbl_player1.BackColor = Color.GreenYellow;//Le fond de couleur du texte du joueur 1 devient blanc
            lbl_player2.BackColor = Color.Yellow;//Le fond de couleur du texte du joueur 2 devient blanc
            cpt = 1;//Le compteur est réinitialisé à 1
            player = 0;//player = 0   =   Joueur 1
            btn_music.Visible = false;//Le bouton "OFF" n'est plus visible
            music1.Stop();//Stop la musique 1
            music2.Stop();//Stop la musique 2
            musique = 0;//Revient sur Musique OFF
            btn_music.Text = ("OFF");//Change le texte du bouton en "OFF"
            for (x = 0; x < int_colonnes; x++)//Tant que x est plus petit que int_colonnes...
            {
                Btn_TabListe[x].BackgroundImage = new Bitmap("LampeEteinteProjetCommun.png");//...Réinitialise les bontons en lampe éteinte
            }//Fin for
        }//Fin réinitialiserToolStripMenuItem_Click

        /*Nom: Fazzi Enzo
         *Date: 02.02.17
         *But: Permet de Quitter le programme
         */
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter la partie en cours?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.Yes)//Si l'un des joueurs clic sur oui dans la messagebox...
            {
                Dispose();//...ferme le programme (STOP)
            }//Fin if
        }//Fin quitterToolStripMenuItem_Click

        /*Nom: Fazzi Enzo
         *Date: 02.02.17
         *But: Quand un joueur clic sur la X, une messagebox s'affiche en demandant si il veut vraiment quitter le jeu
         */
        private void int_lampes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter la partie en cours?", "Quitter", MessageBoxButtons.OKCancel) == DialogResult.OK)//Si l'un des joueurs clic sur oui dans la messagebox...
            {
                Dispose();//...ferme le programme (STOP)
            }//Fin if
            else
            {
                e.Cancel = true;//Arrête l'action qui vient d'être demander au programme
            }
        }//Fin int_lampes_FormClosing

        /*Nom: Fazzi Enzo
         *Date: 10.02.17
         *But: Permet l'affichage du bouton de la musique
         */
        private void musiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btn_demarrer.Text == "Réinitialiser")//Sile texte du bouton Démarrer est = à Réinitialiser...
            {
                btn_music.Visible = true;//...dégrise le bouton music...
            }//Fin if
            else
            {
                btn_music.Visible = false;//...sinon le grise
            }//Fin else
            
        }//Fin musiqueToolStripMenuItem_Click

        /*Nom: Fazzi Enzo
         *Date: 10.02.17
         *But: Permet le choix de la musique
         */
        private void btn_music_Click(object sender, EventArgs e)
        {
            if (musique == 0)
            {
                btn_music.Text = ("ON1");
                music1.PlayLooping();
                musique++;        
            }//Fin if
            else if (musique == 1)
            {
                btn_music.Text = ("ON2");
                music1.Stop();
                music2.PlayLooping();
                musique++;
            }//Fin else if
            else
            {
                btn_music.Text = ("OFF");
                music2.Stop();
                musique = 0;
            }//Fin else
        }//Finbtn_music_Click

        /*Nom: Fazzi Enzo
         *Date: 10.02.17
         *But: Permet le changement du curseur de la souris
         */
        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button MouseHover = (Button)sender;

            if (MouseHover.Image == LampeEteinte)
            {
                MouseHover.Cursor = Cursors.No;
            }//Fin if
            else
            {
                MouseHover.Cursor = Cursors.Hand;
            }//Fin else        
        }//Fin btn_MouseHover
        
    }//Fin partial class

}//Fin namespace
