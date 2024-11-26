using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine197m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine197m";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 196.99322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth193() }, { 1.0d, new AlphaParticle(8171002.09) } } },
            { 4e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine197() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    