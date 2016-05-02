package com.thatcsharpguy.xevensthein.java;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.thatcsharpguy.xevemstheincore.LevenstheinDistance;

public class MainActivity extends AppCompatActivity {

    Button _computeButton;
    TextView _resultTextView;
    EditText _firstWordEditText;
    EditText _secondWordEditText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _computeButton= (Button) this.findViewById(R.id.computeButton);
        _firstWordEditText=(EditText) this.findViewById(R.id.firstWordEditText);
        _secondWordEditText=(EditText) this.findViewById(R.id.secondWordEditText);
        _resultTextView=(TextView)this.findViewById(R.id.resultTextView);

        _computeButton.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                int res = LevenstheinDistance.Compute(_firstWordEditText.getText().toString(),_secondWordEditText.getText().toString());
                _resultTextView.setText(Integer.toString(res));
            }
        });
    }
}
