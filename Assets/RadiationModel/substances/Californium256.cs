using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium256";
        public override double halfLife { get; } = 738.0d;
        public override double atomicWeight { get; } = 256.09344d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1e-08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(234822151077.03) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    