using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium166";
        public override double halfLife { get; } = 0.0105d;
        public override double atomicWeight { get; } = 165.98571d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium162() }, { 1.0d, new AlphaParticle(7737002.09) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium165() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    