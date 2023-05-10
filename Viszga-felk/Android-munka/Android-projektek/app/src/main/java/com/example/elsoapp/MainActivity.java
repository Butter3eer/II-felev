package com.example.elsoapp;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
Button buttonSubmit;
EditText inputText;
TextView kijelzo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        init();
        buttonSubmit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                kijelzo.setText("Hello " + inputText.getText() + "!");
            }
        });
    }

    private void init(){
        buttonSubmit = findViewById(R.id.buttonudv);
        inputText = findViewById(R.id.inputText);
        kijelzo = findViewById(R.id.kijelzo);
    }
}