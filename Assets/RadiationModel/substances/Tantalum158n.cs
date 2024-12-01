using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum158n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 157.96961d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.986d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum158()), new(0.028399999999999998d, new GammaParticle(34500.0, 0.03594)), new(0.128d, new GammaParticle(66100.0, 0.01876)), new(0.0172d, new GammaParticle(159500.0, 0.00777)), new(0.0025d, new GammaParticle(200200.0, 0.00619)), new(0.79d, new GammaParticle(253500.0, 0.00489)), new(0.034d, new GammaParticle(273700.0, 0.00453)), new(0.034d, new GammaParticle(273700.0, 0.00453)), new(0.040999999999999995d, new GammaParticle(418500.0, 0.00296)), new(0.05d, new GammaParticle(435900.0, 0.00284)), new(0.036000000000000004d, new GammaParticle(439200.0, 0.00282)), new(0.0103d, new GammaParticle(474000.0, 0.00262)), new(0.065d, new GammaParticle(583900.0, 0.00212)), new(0.86d, new GammaParticle(599200.0, 0.00207)), new(0.025d, new GammaParticle(634500.0, 0.00195)), new(0.099d, new GammaParticle(708100.0, 0.00175)), new(0.42d, new GammaParticle(747200.0, 0.00166)), new(0.5d, new GammaParticle(778800.0, 0.00159)), new(0.043d, new GammaParticle(782200.0, 0.00159)), new(0.85d, new GammaParticle(1001600.0, 0.00124)), new(0.19897559993024d, new GammaParticle(9424.0, 0.13156)), new(0.028200183254416093d, new GammaParticle(56280.0, 0.02203)), new(0.0491634993975176d, new GammaParticle(57535.0, 0.02155)), new(0.016264648242571886d, new GammaParticle(65315.0, 0.01898)), new(0.020656103268066297d, new GammaParticle(66067.0, 0.01877)), new(0.004391455025494409d, new GammaParticle(66981.0, 0.01851)) } },
            { 0.013999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium154()), new(1.0d, new AlphaParticle(9957002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    