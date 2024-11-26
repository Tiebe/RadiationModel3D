using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium167";
        public override double halfLife { get; } = 0.0302d;
        public override double atomicWeight { get; } = 166.98167d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.435d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium163() }, { 1.0d, new AlphaParticle(7527002.09) } } },
            { 0.39d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium166() }, { 1.0d, new ProtonParticle() } } },
            { 0.175d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium167() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    