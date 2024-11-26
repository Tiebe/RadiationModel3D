using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon146 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon146";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 145.94852d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium146() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.069d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium146() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    