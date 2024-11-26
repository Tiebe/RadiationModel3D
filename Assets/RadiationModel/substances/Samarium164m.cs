using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium164m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 163.95014d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium164() }, { 0.09942999999999999d, new GammaParticle(69000.0, 0.01797) }, { 0.785497d, new GammaParticle(155900.0, 0.00795) }, { 0.278404d, new GammaParticle(242200.0, 0.00512) }, { 0.9943000000000001d, new GammaParticle(349400.0, 0.00355) }, { 0.38777700000000004d, new GammaParticle(668800.0, 0.00185) }, { 0.785497d, new GammaParticle(911300.0, 0.00136) }, { 0.155992669288868d, new GammaParticle(6354.0, 0.19513) }, { 0.1360696968816341d, new GammaParticle(39522.0, 0.03137) }, { 0.2462799943558988d, new GammaParticle(40117.0, 0.03091) }, { 0.0769866270194492d, new GammaParticle(45523.0, 0.02724) }, { 0.09684917679046709d, new GammaParticle(45998.0, 0.02695) }, { 0.019862549771017896d, new GammaParticle(46575.0, 0.02662) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    