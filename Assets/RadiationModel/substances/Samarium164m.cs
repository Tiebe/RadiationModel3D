using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium164m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 163.95014d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium164()), new(0.09942999999999999d, new GammaParticle(69000.0, 0.01797)), new(0.785497d, new GammaParticle(155900.0, 0.00795)), new(0.278404d, new GammaParticle(242200.0, 0.00512)), new(0.9943000000000001d, new GammaParticle(349400.0, 0.00355)), new(0.38777700000000004d, new GammaParticle(668800.0, 0.00185)), new(0.785497d, new GammaParticle(911300.0, 0.00136)), new(0.155992669288868d, new GammaParticle(6354.0, 0.19513)), new(0.1360696968816341d, new GammaParticle(39522.0, 0.03137)), new(0.2462799943558988d, new GammaParticle(40117.0, 0.03091)), new(0.0769866270194492d, new GammaParticle(45523.0, 0.02724)), new(0.09684917679046709d, new GammaParticle(45998.0, 0.02695)), new(0.019862549771017896d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    