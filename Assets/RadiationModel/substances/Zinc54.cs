using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc54 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc54";
        public override double halfLife { get; } = 0.00159d;
        public override double atomicWeight { get; } = 53.99388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel52() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    