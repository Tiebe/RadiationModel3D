using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine113 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine113";
        public override double halfLife { get; } = 6.6d;
        public override double atomicWeight { get; } = 112.92365d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony113() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 3.31e-09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony109() }, { 1.0d, new AlphaParticle(3728002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    