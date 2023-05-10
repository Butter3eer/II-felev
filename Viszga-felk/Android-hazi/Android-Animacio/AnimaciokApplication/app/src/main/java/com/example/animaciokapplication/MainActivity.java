package com.example.animaciokapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.drawable.AnimationDrawable;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private Button buttonBounce, buttonFadeIn, buttonFadeOut, buttonRotate, buttonZoomIn, buttonZoomOut, buttonFrameAnim;
    private TextView textviewBounce, textviewFadeIn, textviewFadeOut, textviewRotate, textviewZoomIn, textviewZoomOut;
    private Animation bounce, fadeIn, fadeOut, rotate, zoomIn, zoomOut;
    private boolean running;
    private ImageView imageViewFrameAnim;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        init();
        buttonBounce.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textviewBounce.startAnimation(bounce);
            }
        });
        buttonFadeIn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textviewFadeIn.startAnimation(fadeIn);
            }
        });
        buttonFadeOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textviewFadeOut.startAnimation(fadeOut);
            }
        });
        buttonRotate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textviewRotate.startAnimation(rotate);
            }
        });
        buttonZoomIn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textviewZoomIn.startAnimation(zoomIn);
            }
        });
        buttonZoomOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textviewZoomOut.startAnimation(zoomOut);
            }
        });
        buttonFrameAnim.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (running) {
                    ((AnimationDrawable) imageViewFrameAnim.getBackground()).stop();
                }
                else{
                    ((AnimationDrawable) imageViewFrameAnim.getBackground()).start();
                }
            }
        });
    }
    private void init(){
        buttonBounce = findViewById(R.id.buttonBounce);
        buttonFadeIn = findViewById(R.id.buttonFadeIn);
        buttonFadeOut = findViewById(R.id.buttonFadeOut);
        buttonRotate = findViewById(R.id.buttonRotate);
        buttonZoomIn = findViewById(R.id.buttonZoomIn);
        buttonZoomOut = findViewById(R.id.buttonZoomOut);

        textviewBounce = findViewById(R.id.textViewBounce);
        textviewFadeIn = findViewById(R.id.textViewFadeIn);
        textviewFadeOut = findViewById(R.id.textViewFadeOut);
        textviewRotate = findViewById(R.id.textViewRotate);
        textviewZoomIn = findViewById(R.id.textViewZoomIn);
        textviewZoomOut = findViewById(R.id.textViewZoomOut);

        bounce = AnimationUtils.loadAnimation(MainActivity.this, R.anim.bounce);
        fadeIn = AnimationUtils.loadAnimation(MainActivity.this, R.anim.fade_in);
        fadeOut = AnimationUtils.loadAnimation(MainActivity.this, R.anim.fade_out);
        rotate = AnimationUtils.loadAnimation(MainActivity.this, R.anim.rotate);
        zoomIn = AnimationUtils.loadAnimation(MainActivity.this, R.anim.zoom_in);
        zoomOut = AnimationUtils.loadAnimation(MainActivity.this, R.anim.zoom_out);

        running = false;
        imageViewFrameAnim = findViewById(R.id.imageFrameAnim);
        buttonFrameAnim = findViewById(R.id.buttonFrameAnim);
    }
}