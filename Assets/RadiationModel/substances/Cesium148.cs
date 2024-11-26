using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium148";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 147.94964d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium148() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.251d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium148() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    