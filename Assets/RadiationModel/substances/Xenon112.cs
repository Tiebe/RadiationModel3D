using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon112 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon112";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 111.93556d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.988d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium112() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.012d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium108() }, { 1.0d, new AlphaParticle(4353002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    