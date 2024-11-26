using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine141 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine141";
        public override double halfLife { get; } = 0.418d;
        public override double atomicWeight { get; } = 140.93567d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon141() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.212d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon141() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    