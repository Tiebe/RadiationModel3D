using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium283";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 283.17666d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Roentgenium279() }, { 1.0d, new AlphaParticle(11437002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    