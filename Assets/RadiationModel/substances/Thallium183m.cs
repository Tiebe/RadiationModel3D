using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium183m";
        public override double halfLife { get; } = 0.0533d;
        public override double atomicWeight { get; } = 182.98287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold179()), new(1.0d, new AlphaParticle(7627002.09)), new(0.001d, new GammaParticle(52400.0, 0.02366)), new(0.0113d, new GammaParticle(61800.0, 0.02006)), new(0.0011d, new GammaParticle(89400.0, 0.01387)), new(0.005557856477599999d, new GammaParticle(11419.0, 0.10858)), new(0.00020918302115818276d, new GammaParticle(66991.0, 0.01851)), new(0.00035611682185594605d, new GammaParticle(68806.0, 0.01802)), new(0.00012016459036917867d, new GammaParticle(78048.0, 0.01589)), new(0.0001548921569858713d, new GammaParticle(78983.0, 0.0157)), new(3.4727566616692633e-05d, new GammaParticle(80133.0, 0.01547)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    