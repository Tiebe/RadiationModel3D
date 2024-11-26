using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium283";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 283.17321d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Darmstadtium279() }, { 1.0d, new AlphaParticle(10917002.09) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    