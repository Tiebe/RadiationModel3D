using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium177m";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 176.99728d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury176() }, { 1.0d, new ProtonParticle() } } },
            { 0.49d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold173() }, { 1.0d, new AlphaParticle(8896002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    