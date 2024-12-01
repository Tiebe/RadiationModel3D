using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium149";
        public override double halfLife { get; } = 8043840.0d;
        public override double atomicWeight { get; } = 148.91794d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium149()), new(0.0271d, new GammaParticle(22500.2, 0.0551)), new(0.000165d, new GammaParticle(72983.0, 0.01699)), new(3.3e-06d, new GammaParticle(122000.0, 0.01016)), new(4.7e-06d, new GammaParticle(129500.0, 0.00957)), new(3.7000000000000005e-05d, new GammaParticle(130098.0, 0.00953)), new(0.000257d, new GammaParticle(178580.0, 0.00694)), new(0.000145d, new GammaParticle(208283.0, 0.00595)), new(0.00013d, new GammaParticle(251510.0, 0.00493)), new(0.0075d, new GammaParticle(254566.0, 0.00487)), new(1.4999999999999998e-06d, new GammaParticle(272210.0, 0.00455)), new(0.0418d, new GammaParticle(277089.0, 0.00447)), new(0.000263d, new GammaParticle(281295.0, 0.00441)), new(8.1e-06d, new GammaParticle(285950.0, 0.00434)), new(1.2e-06d, new GammaParticle(308000.0, 0.00403)), new(0.0475d, new GammaParticle(327526.0, 0.00379)), new(0.00425d, new GammaParticle(350016.0, 0.00354)), new(3.3e-07d, new GammaParticle(376500.0, 0.00329)), new(4.1e-05d, new GammaParticle(381700.0, 0.00325)), new(0.00645d, new GammaParticle(506093.0, 0.00245)), new(0.00605d, new GammaParticle(528587.0, 0.00235)), new(0.000536d, new GammaParticle(535897.0, 0.00231)), new(0.00063d, new GammaParticle(558372.0, 0.00222)), new(2.9e-07d, new GammaParticle(568270.0, 0.00218)), new(1.13e-06d, new GammaParticle(590880.0, 0.0021)), new(3.06e-06d, new GammaParticle(613915.0, 0.00202)), new(3.5e-06d, new GammaParticle(636050.0, 0.00195)), new(1.77e-06d, new GammaParticle(636500.0, 0.00195)), new(0.235d, new GammaParticle(6354.0, 0.19513)), new(0.22d, new GammaParticle(39522.0, 0.03137)), new(0.397d, new GammaParticle(40117.0, 0.03091)), new(0.124d, new GammaParticle(45523.0, 0.02724)), new(0.156d, new GammaParticle(45998.0, 0.02695)), new(0.032d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    