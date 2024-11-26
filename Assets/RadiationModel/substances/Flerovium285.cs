using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium285 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium285";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 285.1835d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copernicium281() }, { 1.0d, new AlphaParticle(11577002.09) } } },
            { 0.125d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    