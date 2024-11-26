using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium114";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 113.94129d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99982d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine114() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.087d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine113() }, { 1.0d, new ProtonParticle() } } },
            { 0.0019d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium110() }, { 1.0d, new AlphaParticle(16137002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    