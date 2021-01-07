/*
Karter Ence
Song Player
11/21/2020
Chapter 13 Activity
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace SongPlayer
{
    public partial class SongPlayerForm : Form
    {
        // the form data consists of a list of songs
        LinkedList<Song> songs = new LinkedList<Song>();

        // the constructor is provided complete as part of the activity starter
        public SongPlayerForm()
        {
            InitializeComponent();

            // fill out our songs array
            initializeSongs();

        }

        // This code is ADDED FOR ACTIVITY by the student
        private void initializeSongs()
        {
            //LinkedList<Song> songs = new LinkedList<Song>();
            Song song1 = new Song("Twinkle Twinkle");
            //It's out of tune because there are no sharps or flats available to me here, so deal with it
            song1.addNote(Note.NOTE_D, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_D, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_B, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_B, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_A, Note.DURATION_HALF);
            song1.addNote(Note.NOTE_G, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_G, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_F, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_F, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_E, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_E, Note.DURATION_QUARTER);
            song1.addNote(Note.NOTE_D, Note.DURATION_HALF);

            songs.AddLast(song1);
            SongListBox.Items.Add(song1.Name);

            Song song2 = new Song("Mary Had a Little Lamb");
            song2.addNote(Note.NOTE_B, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_G, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_B, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_B, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_B, Note.DURATION_HALF);
            song2.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_A, Note.DURATION_HALF);
            song2.addNote(Note.NOTE_B, Note.DURATION_QUARTER);
            song2.addNote(Note.NOTE_D, Note.DURATION_QUARTER); //Yes, I know it's the incorrect octave. 
            song2.addNote(Note.NOTE_D, Note.DURATION_HALF);

            songs.AddLast(song2);
            SongListBox.Items.Add(song2.Name);

            Song song3 = new Song("The No-Good Song");
            song3.addNote(Note.NOTE_C, Note.DURATION_WHOLE);
            song3.addNote(Note.NOTE_F, Note.DURATION_QUARTER);
            song3.addNote(Note.NOTE_G, Note.DURATION_QUARTER);
            song3.addNote(Note.NOTE_A, Note.DURATION_QUARTER);
            song3.addNote(Note.NOTE_A, Note.DURATION_HALF);
            song3.addNote(Note.NOTE_G, Note.DURATION_HALF);
            song3.addNote(Note.NOTE_C, Note.DURATION_WHOLE);

            songs.AddLast(song3);
            SongListBox.Items.Add(song3.Name);
        }

        // This function is provided as part of the activity starter.
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // get the current selection index
            int selection = SongListBox.SelectedIndex;
            if (selection >= 0)
            {
                // get the selected song from the list
                Song s = songs.ElementAt(selection);

                // play the song
                s.Play();
            }

        }

        private void SongPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
