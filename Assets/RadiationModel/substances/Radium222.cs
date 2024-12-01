using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium222";
        public override double halfLife { get; } = 33.6d;
        public override double atomicWeight { get; } = 222.01537d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon218()), new(1.0d, new AlphaParticle(7699602.09)), new(1.1e-06d, new GammaParticle(144400.0, 0.00859)), new(0.0277d, new GammaParticle(324310.0, 0.00382)), new(4e-05d, new GammaParticle(328900.0, 0.00377)), new(3.9e-05d, new GammaParticle(472590.0, 0.00262)), new(1.42e-05d, new GammaParticle(515830.0, 0.0024)), new(1.7e-06d, new GammaParticle(796800.0, 0.00156)), new(2.8e-05d, new GammaParticle(840180.0, 0.00148)), new(0.001009619420527008d, new GammaParticle(14088.0, 0.08801)), new(0.0004588724857150979d, new GammaParticle(81070.0, 0.01529)), new(0.0007569654993650576d, new GammaParticle(83789.0, 0.0148)), new(0.00026251047405139724d, new GammaParticle(94878.0, 0.01307)), new(0.00034651382574784435d, new GammaParticle(96054.0, 0.01291)), new(8.400335169644711e-05d, new GammaParticle(97530.0, 0.01271)) } },
            { 3e-10d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    