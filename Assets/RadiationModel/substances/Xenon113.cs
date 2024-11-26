using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon113 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon113";
        public override double halfLife { get; } = 2.74d;
        public override double atomicWeight { get; } = 112.93322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium113() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium112() }, { 1.0d, new ProtonParticle() } } },
            { 0.00010999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium109() }, { 1.0d, new AlphaParticle(4108002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    