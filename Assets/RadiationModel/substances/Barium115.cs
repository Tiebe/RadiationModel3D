using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium115";
        public override double halfLife { get; } = 0.45d;
        public override double atomicWeight { get; } = 114.94748d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon115() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon114() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    