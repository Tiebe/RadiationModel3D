using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium117";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 116.93831d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon117() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon116() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.0d, new ProtonParticle() } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium117() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    