using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead203 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead203";
        public override double halfLife { get; } = 186912.0d;
        public override double atomicWeight { get; } = 202.97339d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium203()), new(0.8094d, new GammaParticle(279195.2, 0.00444)), new(0.0335d, new GammaParticle(401320.0, 0.00309)), new(0.00754d, new GammaParticle(680515.0, 0.00182)), new(0.348072261704804d, new GammaParticle(12148.0, 0.10206)), new(0.2547749186122931d, new GammaParticle(70832.0, 0.0175)), new(0.43007244870407346d, new GammaParticle(72874.0, 0.01701)), new(0.1462626991107429d, new GammaParticle(82629.0, 0.015)), new(0.18970272074663355d, new GammaParticle(83631.0, 0.01483)), new(0.04344002163589065d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    