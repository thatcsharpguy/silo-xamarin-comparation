package com.thatcsharpguy.xevensthein.java;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.thatcsharpguy.xevenstheincore.LevenstheinDistance;

public class MainActivity extends AppCompatActivity {

    Button _compareButton;
    TextView _resultTextView;
    EditText _firstWordEditText;
    EditText _secondWordEditText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _compareButton = (Button)findViewById(R.id.compareButton);
        _firstWordEditText=(EditText) findViewById(R.id.firstWordEditText);
        _secondWordEditText=(EditText) findViewById(R.id.secondWordEditText);
        _resultTextView=(TextView)findViewById(R.id.resultTextView);

        _compareButton.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                int res = LevenstheinDistance.Compute(_firstWordEditText.getText().toString(),_secondWordEditText.getText().toString());
                _resultTextView.setText(Integer.toString(res));
            }
        });
    }
}
