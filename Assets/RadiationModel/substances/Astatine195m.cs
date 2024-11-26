using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine195m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine195m";
        public override double halfLife { get; } = 0.143d;
        public override double atomicWeight { get; } = 194.99631d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth191()), new(1.0d, new AlphaParticle(8395002.09)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine195()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    