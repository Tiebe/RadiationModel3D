using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium182";
        public override double halfLife { get; } = 78624.0d;
        public override double atomicWeight { get; } = 181.95211d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium182()), new(2.05e-05d, new GammaParticle(5470.0, 0.22666)), new(0.006288d, new GammaParticle(27530.0, 0.04504)), new(0.058164d, new GammaParticle(55500.0, 0.02234)), new(0.0023055999999999997d, new GammaParticle(110460.0, 0.01122)), new(0.00036679999999999997d, new GammaParticle(111390.0, 0.01113)), new(0.0066024000000000005d, new GammaParticle(115920.0, 0.0107)), new(0.004192d, new GammaParticle(122300.0, 0.01014)), new(0.033012d, new GammaParticle(130800.0, 0.00948)), new(0.0004716d, new GammaParticle(136900.0, 0.00906)), new(0.0008384d, new GammaParticle(143500.0, 0.00864)), new(5.24e-05d, new GammaParticle(164200.0, 0.00755)), new(0.0001048d, new GammaParticle(166100.0, 0.00746)), new(0.002096d, new GammaParticle(170440.0, 0.00727)), new(0.003406d, new GammaParticle(172410.0, 0.00719)), new(0.0027248d, new GammaParticle(174980.0, 0.00709)), new(0.3406d, new GammaParticle(180200.0, 0.00688)), new(5.24e-05d, new GammaParticle(186700.0, 0.00664)), new(0.0002096d, new GammaParticle(190000.0, 0.00653)), new(0.00056592d, new GammaParticle(202510.0, 0.00612)), new(0.000262d, new GammaParticle(203700.0, 0.00609)), new(0.000262d, new GammaParticle(207800.0, 0.00597)), new(0.007388400000000001d, new GammaParticle(216910.0, 0.00572)), new(0.000524d, new GammaParticle(223000.0, 0.00556)), new(0.0034584d, new GammaParticle(235750.0, 0.00526)), new(0.009170000000000001d, new GammaParticle(241310.0, 0.00514)), new(0.006026d, new GammaParticle(246770.0, 0.00502)), new(0.0008384d, new GammaParticle(261500.0, 0.00474)), new(0.067596d, new GammaParticle(263290.0, 0.00471)), new(0.0002096d, new GammaParticle(268800.0, 0.00461)), new(0.0182352d, new GammaParticle(274330.0, 0.00452)), new(0.0006288000000000001d, new GammaParticle(286390.0, 0.00433)), new(0.000262d, new GammaParticle(292300.0, 0.00424)), new(0.000262d, new GammaParticle(302400.0, 0.0041)), new(0.0001048d, new GammaParticle(315200.0, 0.00393)), new(0.0001048d, new GammaParticle(317000.0, 0.00391)), new(0.00036679999999999997d, new GammaParticle(338000.0, 0.00367)), new(0.0001048d, new GammaParticle(340100.0, 0.00365)), new(0.000262d, new GammaParticle(359000.0, 0.00345)), new(0.00031440000000000005d, new GammaParticle(369200.0, 0.00336)), new(0.00031440000000000005d, new GammaParticle(373200.0, 0.00332)), new(0.007388400000000001d, new GammaParticle(379220.0, 0.00327)), new(0.0001048d, new GammaParticle(395700.0, 0.00313)), new(0.0002096d, new GammaParticle(402600.0, 0.00308)), new(0.000786d, new GammaParticle(438460.0, 0.00283)), new(5.24e-05d, new GammaParticle(441000.0, 0.00281)), new(0.000262d, new GammaParticle(450300.0, 0.00275)), new(0.0029343999999999998d, new GammaParticle(454600.0, 0.00273)), new(0.000262d, new GammaParticle(458000.0, 0.00271)), new(0.000262d, new GammaParticle(458280.0, 0.00271)), new(0.00015720000000000003d, new GammaParticle(475100.0, 0.00261)), new(0.000262d, new GammaParticle(479900.0, 0.00258)), new(0.0004716d, new GammaParticle(486000.0, 0.00255)), new(0.000524d, new GammaParticle(494600.0, 0.00251)), new(0.0027772d, new GammaParticle(499080.0, 0.00248)), new(0.524d, new GammaParticle(510040.0, 0.00243)), new(0.0027248d, new GammaParticle(554680.0, 0.00224)), new(0.00031440000000000005d, new GammaParticle(560800.0, 0.00221)), new(0.00031440000000000005d, new GammaParticle(580000.0, 0.00214)), new(0.0002096d, new GammaParticle(631100.0, 0.00196)), new(0.00131d, new GammaParticle(726980.0, 0.00171)), new(0.39d, new GammaParticle(10063.0, 0.12321)), new(0.23399999999999999d, new GammaParticle(59718.0, 0.02076)), new(0.4d, new GammaParticle(61141.0, 0.02028)), new(0.135d, new GammaParticle(69395.0, 0.01787)), new(0.172d, new GammaParticle(70206.0, 0.01766)), new(0.037000000000000005d, new GammaParticle(71195.0, 0.01741)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    