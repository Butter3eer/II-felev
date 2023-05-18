package com.example.akasztofaapp;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.helper.widget.Flow;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.button.MaterialButton;

public class MainActivity extends AppCompatActivity {
    ImageView imageExecutionPlace, imageHelp;
    TextView megfejtesAllapot, textHelp;
    ConstraintLayout layoutLetters;
    Flow flowLetters;

    char[] letters_en = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".toCharArray();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        init();
        addLetterButtons(letters_en);
    }
    private void init() {
        imageExecutionPlace = findViewById(R.id.imageExecutionPlace);
        megfejtesAllapot = findViewById(R.id.megfejtesAllapot);
        imageHelp = findViewById(R.id.imageHelp);
        textHelp = findViewById(R.id.textHelp);
        layoutLetters = findViewById(R.id.layoutLetters);
        flowLetters = findViewById(R.id.flowLetters);
    }

    /**
     * A választott nyelv ABC-nek megfelelő parancsgombokat a felületre helyezi.
     * @param letters
     */
    private void addLetterButtons(char[] letters){
        int[] referenceIds = new int[letters.length];
        for (int i = 0; i < letters.length; i++) {
            MaterialButton myButton = new MaterialButton(this);
            myButton.setText(String.valueOf(letters[i]).toUpperCase());
            myButton.setId(View.generateViewId());

            final int id = myButton.getId();
            referenceIds[i] = id;
            myButton.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    // TODO: 18/05/2023 Leellenőrizzük, szerepel... 
                    Toast.makeText(MainActivity.this, "Kattintott a " + String.valueOf(letters[id - 1]).toUpperCase() + " feliratú gombra.", Toast.LENGTH_SHORT).show();
                }
            });

            layoutLetters.addView(myButton);
        }
        flowLetters.setReferencedIds(referenceIds);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater=getMenuInflater();
        inflater.inflate(R.menu.mainemenu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.menuItemHard:
                Toast.makeText(this, "Nehéz szintet válsztott", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menuItemEasy:
                Toast.makeText(this, "Könnyű szintet válsztott", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menuItemBiology:
                Toast.makeText(this, "Biolőgia kategóriát választott", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menuItemMathematics:
                Toast.makeText(this, "Matematika kategóriát válsztott", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menuItemBuildings:
                Toast.makeText(this, "Épületeket válsztott", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menuItemIt:
                Toast.makeText(this, "Informatikát válsztott", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menuExit:
                Toast.makeText(this, "Kilépés a programból", Toast.LENGTH_SHORT).show();
                this.finishAffinity();
                return true;
        }
        return super.onOptionsItemSelected(item);
    }
}