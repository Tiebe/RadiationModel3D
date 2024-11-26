using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium158";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 157.94932d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9909d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium158() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0091d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium154() }, { 1.0d, new AlphaParticle(5812002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    