using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium246";
        public override double halfLife { get; } = 128520.0d;
        public override double atomicWeight { get; } = 246.0688d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium242() }, { 1.0d, new AlphaParticle(7883502.09) }, { 0.000178d, new GammaParticle(42000.0, 0.02952) }, { 0.00012d, new GammaParticle(96000.0, 0.01292) }, { 3.5000000000000004e-05d, new GammaParticle(147000.0, 0.00843) }, { 0.08090078064505d, new GammaParticle(18579.0, 0.06673) }, { 1.732160917957335e-06d, new GammaParticle(104606.0, 0.01185) }, { 2.712010205037318e-06d, new GammaParticle(109286.0, 0.01134) }, { 1.0157166250039554e-06d, new GammaParticle(123280.0, 0.01006) }, { 1.3732488770053477e-06d, new GammaParticle(124855.0, 0.00993) }, { 3.5753225200139227e-07d, new GammaParticle(126917.0, 0.00977) } } },
            { 4e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium246() } } },
            { 2.4e-06d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    