using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium236";
        public override double halfLife { get; } = 408.0d;
        public override double atomicWeight { get; } = 236.05137d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.82d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium236()) } },
            { 0.18d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium232()), new(1.0d, new AlphaParticle(8089002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    