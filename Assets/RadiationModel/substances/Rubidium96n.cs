using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium96n : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium96n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.93535d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium96()), new(0.07d, new GammaParticle(38000.0, 0.03263)), new(0.07d, new GammaParticle(38000.0, 0.03263)), new(0.036000000000000004d, new GammaParticle(40000.0, 0.031)), new(0.17d, new GammaParticle(59300.0, 0.02091)), new(0.08d, new GammaParticle(89500.0, 0.01385)), new(0.37d, new GammaParticle(92800.0, 0.01336)), new(0.36d, new GammaParticle(116800.0, 0.01062)), new(0.32d, new GammaParticle(122000.0, 0.01016)), new(0.36d, new GammaParticle(123500.0, 0.01004)), new(0.07d, new GammaParticle(126000.0, 0.00984)), new(0.07d, new GammaParticle(148800.0, 0.00833)), new(0.07d, new GammaParticle(166100.0, 0.00746)), new(0.12d, new GammaParticle(177600.0, 0.00698)), new(0.12d, new GammaParticle(185400.0, 0.00669)), new(0.16d, new GammaParticle(209900.0, 0.00591)), new(0.42d, new GammaParticle(240300.0, 0.00516)), new(0.05d, new GammaParticle(276300.0, 0.00449)), new(0.68d, new GammaParticle(300000.0, 0.00413)), new(0.17d, new GammaParticle(301000.0, 0.00412)), new(0.07d, new GammaParticle(329000.0, 0.00377)), new(0.1d, new GammaParticle(366800.0, 0.00338)), new(0.13d, new GammaParticle(369200.0, 0.00336)), new(0.03d, new GammaParticle(402400.0, 0.00308)), new(0.04d, new GammaParticle(405500.0, 0.00306)), new(0.48d, new GammaParticle(461600.0, 0.00269)), new(0.05d, new GammaParticle(495200.0, 0.0025)), new(0.05d, new GammaParticle(554500.0, 0.00224)), new(0.03307238067d, new GammaParticle(1767.0, 0.70166)), new(0.19543802334162166d, new GammaParticle(13336.0, 0.09297)), new(0.37620408727934873d, new GammaParticle(13396.0, 0.09255)), new(0.09158567148658557d, new GammaParticle(15021.0, 0.08254)), new(0.10220960937902951d, new GammaParticle(15070.0, 0.08227)), new(0.010623937892443926d, new GammaParticle(15187.0, 0.08164)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    