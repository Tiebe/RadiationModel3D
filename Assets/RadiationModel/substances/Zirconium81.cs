using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium81";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 80.93825d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium81() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0012d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium80() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    