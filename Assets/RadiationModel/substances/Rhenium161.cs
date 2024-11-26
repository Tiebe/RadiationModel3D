using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium161";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 160.97763d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten160()), new(1.0d, new ProtonParticle()) } },
            { 0.013999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum157()), new(1.0d, new AlphaParticle(7357002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    