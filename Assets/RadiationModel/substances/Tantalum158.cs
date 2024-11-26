using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum158 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 157.96659d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium154() }, { 1.0d, new AlphaParticle(7147002.09) } } },
            { 0.09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium158() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    