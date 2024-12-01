using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium157";
        public override double halfLife { get; } = 2240541744.19603d;
        public override double atomicWeight { get; } = 156.92403d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium157()), new(8.4e-05d, new GammaParticle(54500.0, 0.02275)), new(0.000149621472d, new GammaParticle(6858.0, 0.18079)), new(0.00021213192690866536d, new GammaParticle(42308.0, 0.02931)), new(0.00038160087589254426d, new GammaParticle(42996.0, 0.02884)), new(0.00012062694948439461d, new GammaParticle(48802.0, 0.02541)), new(0.0001523518371987904d, new GammaParticle(49326.0, 0.02514)), new(3.172488771439578e-05d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    