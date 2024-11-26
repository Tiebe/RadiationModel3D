using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine191m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine191m";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 191.00421d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth187() }, { 1.0d, new AlphaParticle(8902002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    