using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium167m";
        public override double halfLife { get; } = 0.0286d;
        public override double atomicWeight { get; } = 166.98186d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium163() }, { 1.0d, new AlphaParticle(7702002.09) } } },
            { 0.096d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium167() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0042d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium166() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    