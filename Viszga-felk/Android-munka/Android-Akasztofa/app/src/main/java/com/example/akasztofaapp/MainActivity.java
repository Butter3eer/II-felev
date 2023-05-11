package com.example.akasztofaapp;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater=getMenuInflater();
        inflater.inflate(R.menu.beallitasok_menu, menu);
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