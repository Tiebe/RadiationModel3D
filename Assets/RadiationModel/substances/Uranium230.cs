using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium230";
        public override double halfLife { get; } = 1747872.0d;
        public override double atomicWeight { get; } = 230.03394d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium226()), new(1.0d, new AlphaParticle(7014002.09)), new(0.006d, new GammaParticle(72200.0, 0.01717)), new(4.8e-06d, new GammaParticle(81000.0, 0.01531)), new(0.00125d, new GammaParticle(154230.0, 0.00804)), new(0.0007000000000000001d, new GammaParticle(158180.0, 0.00784)), new(5e-07d, new GammaParticle(221000.0, 0.00561)), new(2.4e-06d, new GammaParticle(223900.0, 0.00554)), new(0.00122d, new GammaParticle(230370.0, 0.00538)), new(0.000117d, new GammaParticle(235300.0, 0.00527)), new(3.5e-07d, new GammaParticle(539000.0, 0.0023)), new(2.9999999999999997e-06d, new GammaParticle(574800.0, 0.00216)), new(4.0000000000000003e-07d, new GammaParticle(617000.0, 0.00201)), new(0.11198046188102978d, new GammaParticle(15784.0, 0.07855)), new(0.0001324383903814634d, new GammaParticle(89954.0, 0.01378)), new(0.00021423227172672824d, new GammaParticle(93347.0, 0.01328)), new(7.623124507091126e-05d, new GammaParticle(105566.0, 0.01174)), new(0.00010192117465980835d, new GammaParticle(106894.0, 0.0116)), new(2.568992958889709e-05d, new GammaParticle(108580.0, 0.01142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    