//
//  ViewController.swift
//  Xevensthein
//
//  Created by Antonio Feregrino Bolaños on 4/29/16.
//  Copyright © 2016 That C# guy. Some rights reserved.
//

import UIKit
import XevenstheinCore

class ViewController: UIViewController, UITextFieldDelegate {
    
    // MARK: Properties
    @IBOutlet var firstWordTextField: UITextField!
    @IBOutlet var secondWordTextField: UITextField!
    @IBOutlet var compareButton: UIButton!
    @IBOutlet var resultLabel: UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        firstWordTextField.delegate = self;
        secondWordTextField.delegate = self;
        
        compareButton.addTarget(self, action: #selector(ViewController.compareButtonClicked(_:)), forControlEvents: .TouchUpInside);
    }
    
    func compareButtonClicked(_sender : AnyObject?){
        let result = LevenshteinDistance.compute( firstWordTextField.text!,t: secondWordTextField.text!);
        resultLabel.text = String(result);
    }
    
    func textFieldShouldReturn(textField: UITextField) -> Bool {
        if(textField == firstWordTextField){
            firstWordTextField.resignFirstResponder();
            secondWordTextField.becomeFirstResponder();
        }
        else{
            secondWordTextField.resignFirstResponder();
        }
        return true;
    }
    

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

