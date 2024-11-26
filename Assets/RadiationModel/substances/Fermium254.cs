using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium254";
        public override double halfLife { get; } = 11664.0d;
        public override double atomicWeight { get; } = 254.08685d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999408d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium250() }, { 1.0d, new AlphaParticle(8329202.090000001) }, { 0.00013d, new GammaParticle(42760.0, 0.029) }, { 0.00031d, new GammaParticle(99160.0, 0.0125) }, { 9.99408e-06d, new GammaParticle(151000.0, 0.00821) }, { 0.07043223556305235d, new GammaParticle(19579.0, 0.06333) }, { 4.4981069338201885e-07d, new GammaParticle(109867.0, 0.01128) }, { 6.960858764809949e-07d, new GammaParticle(115063.0, 0.01078) }, { 2.6534773077948837e-07d, new GammaParticle(129671.0, 0.00956) }, { 3.5981152293698626e-07d, new GammaParticle(131332.0, 0.00944) }, { 9.446379215749787e-08d, new GammaParticle(133529.0, 0.00929) } } },
            { 0.0005920000000000001d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    